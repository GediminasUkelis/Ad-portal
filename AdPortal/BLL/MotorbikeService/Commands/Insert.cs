using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.MotorbikeService.Commands
{
    public class Insert
    {
        public class Command : IRequest
        {
        public Command(string obj, List<IFormFile> Image)
            {
                this.obj = obj;
                this.Image = Image;
            }
            public string obj { get; set; }
            public List<IFormFile> Image { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                if (request.obj == null)
                {
                    throw new StatusCodeException(HttpStatusCode.BadRequest, "object is empty");
                }
                VehicleDto MotorbikeObj = JsonConvert.DeserializeObject<VehicleDto>(JObject.Parse(request.obj).ToString());

                MotorbikeVehicleDtoValidation validator = new MotorbikeVehicleDtoValidation();
                ValidationResult results = validator.Validate(MotorbikeObj);
                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(MotorbikeObj);
                }

                var obj = uow.Mapper.Map<Vehicle>(MotorbikeObj);
                var accessToken = uow.httpContextAccessor.HttpContext.User.Identity.Name;
                Guid id;
                if (!Guid.TryParse(accessToken, out id))
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "guid has bad structure");
                }
                obj.UserId = id;
                if (request.Image == null)
                {
                    throw new StatusCodeException(HttpStatusCode.BadRequest, "Image is empty");
                }
                if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Images\" + obj.Id))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Images\" + obj.Id);
                }

                foreach (var image in request.Image)
                {
                    string fileName = Guid.NewGuid() + image.FileName;
                    if (image.Length > 0)
                    {
                        using (var fileStream = new FileStream(Directory.GetCurrentDirectory()
                            + @"\Images\" + obj.Id + @"\" + fileName, FileMode.Create))
                        {
                            image.CopyTo(fileStream);
                            var path = new Image()
                            {
                                Path = Directory.GetCurrentDirectory()
                            + "\\Images\\" + obj.Id + "\\" + fileName
                            };
                            obj.Image.Add(path);
                        }
                    }
                }
                obj.CarDetails = null;
                obj.BikeDetails.VehicleId = obj.Id;
                await uow.MotorbikeRepository.Insert(obj);
                uow.Commit();
                return Unit.Value;
            }
        }
    }
}
