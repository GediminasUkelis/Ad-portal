using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.ImageService.Commands
{
    public class Insert
    {
        public class Command : IRequest
        {
            public Command(Guid PostId, List<IFormFile> Images)
            {
                this.PostId = PostId;
                this.Images = Images;
            }
            public Guid PostId { get; set; }
            public List<IFormFile> Images { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IUnitOfWork uow;
            private Image image;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                if (request.Images.Count < 1)
                {
                    throw new StatusCodeException(HttpStatusCode.BadRequest, "No images selected");
                }

                var accessToken = uow.httpContextAccessor.HttpContext.User.Identity.Name;
                Guid id;
                if (!Guid.TryParse(accessToken, out id))
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "guid has bad structure");
                }
                var User = uow.UserRepository.GetById(id);

                var userCars = User.Cars.FirstOrDefault(c => c.Id == request.PostId);
                var userBikes = User.Motorbikes.FirstOrDefault(c => c.Id == request.PostId);
                var userTires = User.Tires.FirstOrDefault(c => c.Id == request.PostId);
                if (userCars == null && userBikes == null && userTires == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Post doesnt exist");
                }
                if(userCars!=null)
                {
                    userCars = uow.CarRepository.GetById(userCars.Id);
                }
                if (userBikes != null)
                {
                    userBikes = uow.MotorbikeRepository.GetById(userBikes.Id);
                }
                if (userTires != null)
                {
                    userTires = uow.TireRepository.GetById(userTires.Id);
                }
                
                if (userCars == null && userBikes == null && userTires == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Post doesnt exist");
                }
                if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Images\" + request.PostId))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Images\" + request.PostId);
                }
                foreach (var item in request.Images)
                {
                    string fileName = Guid.NewGuid() + item.FileName;
                    if (item.Length > 0)
                    {
                        using (var fileStream = new FileStream(Directory.GetCurrentDirectory()
                            + @"\Images\" + request.PostId + @"\" + fileName, FileMode.Create))
                        {
                            item.CopyTo(fileStream);
                            if (userCars != null)
                            {
                                image = new Image()
                                {
                                    Path = Directory.GetCurrentDirectory()
                                    + "\\Images\\" + request.PostId + "\\" + fileName,
                                    CarId = request.PostId
                                };
                            }
                            else if(userBikes!=null)
                            {
                                image = new Image()
                                {
                                    Path = Directory.GetCurrentDirectory()
                                     + "\\Images\\" + request.PostId + "\\" + fileName ,
                                   MotorbikeId =request.PostId
                                };
                            }
                            else
                            {
                                image = new Image()
                                {
                                    Path = Directory.GetCurrentDirectory()
                                    + "\\Images\\" + request.PostId + "\\" + fileName,
                                    TireId=request.PostId
                                };
                            }
                            //path.Path.Replace(@"\\", @"\");

                            uow.ImageRepository.Insert(image);
                            if (userCars != null)
                                userCars.Image.Add(image);
                            if (userBikes != null)
                                userBikes.Image.Add(image);
                            if (userTires != null)
                                userTires.Image.Add(image);
                        }
                    }
                }
                uow.Commit();
                return Unit.Value;
            }
        }
    }
}
