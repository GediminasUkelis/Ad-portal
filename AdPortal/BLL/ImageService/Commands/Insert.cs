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
                var User = await uow.UserRepository.GetById(id);

                var dbEntry = User.Vehicles.FirstOrDefault(c => c.Id == request.PostId);
                if (dbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Post doesnt exist");
                }

                //if(userCars!=null)
                //{
                //    userCars = await uow.CarRepository.GetById(userCars.Id);
                //}
                //if (userBikes != null)
                //{
                //    userBikes = await uow.MotorbikeRepository.GetById(userBikes.Id);
                //}
                //if (userCars == null && userBikes == null )
                //{
                //    throw new StatusCodeException(HttpStatusCode.NotFound, "Post doesnt exist");
                //}

                if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Images\" + request.PostId))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Images\" + request.PostId);
                }
                foreach (var item in request.Images)
                {
                    if (item.Length > 0)
                    {
                        using (var fileStream = new FileStream(Directory.GetCurrentDirectory()
               + @"\Images\" + request.PostId + @"\" + Guid.NewGuid() + item.FileName, FileMode.Create))
                        {
                            item.CopyTo(fileStream);
                            var image = new Image()
                            {
                                Path = Directory.GetCurrentDirectory()
                                          + "\\Images\\" + request.PostId + "\\" + Guid.NewGuid() + item.FileName,
                                ProductId = request.PostId
                            };
                            await uow.ImageRepository.Insert(image);
                            dbEntry.Image.Add(image);

                        }
                    }
                }
                uow.Commit();
                return Unit.Value;
            }
        }
    }
}
