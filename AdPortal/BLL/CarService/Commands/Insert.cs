using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Commands
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
                CarDto CarObj = JsonConvert.DeserializeObject<CarDto>(JObject.Parse(request.obj).ToString());
                CarDtoValidator validator = new CarDtoValidator();
                ValidationResult results = validator.Validate(CarObj);
                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(CarObj);
                }
                
                var obj = uow.Mapper.Map<Car>(CarObj);
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
                foreach (var image in request.Image)
                {
                    if (image.Length > 0)
                    {
                        var filePath = Path.GetTempFileName();
                        using (var stream = File.Create(filePath))
                        {
                            using (var ms = new MemoryStream())
                            {
                                image.CopyTo(ms);
                                var fileBytes = ms.ToArray();
                                var  ImageBytes = String.Join(" ", fileBytes);
                                Image image1 = new Image()
                                {
                                    Cars = obj,
                                    Bytes = ImageBytes
                                };
                                obj.Image.Add(image1);
                         
                            }
                        }
                    }
                }
                //obj.CreatedOn = DateTime.UtcNow;
                uow.CarRepository.Insert(obj);
                uow.Commit();
                return Unit.Value;
                
            }
        }
    }
}

