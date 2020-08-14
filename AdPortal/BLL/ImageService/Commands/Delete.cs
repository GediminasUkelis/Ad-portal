using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using Cqrs.Events;
using Domain.Models;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.ImageService.Commands
{
    public class Delete
    {

        public class Command : IRequest
        {
            public Command(Guid Id,List<ImageDto> Images)
            {
                this.Id = Id;
                this.Images = Images;
            }
            public Guid Id { get; set; }
            public List<ImageDto> Images { get; set; }
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

                var userCars = User.Cars.FirstOrDefault(c => c.Id == request.Id);
                var userBikes = User.Motorbikes.FirstOrDefault(c => c.Id == request.Id);
                if (userCars == null&& userBikes==null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Post doesnt exist");
                }
                var carEntry = await uow.CarRepository.GetById(userCars.Id);
                var motorbikeEntry = await uow.MotorbikeRepository.GetById(userCars.Id);

                if (carEntry == null && motorbikeEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Post doesnt exist");
                }
                if (carEntry != null)
                {
                    foreach (var image in request.Images)
                    {
                        var item = carEntry.Image.FirstOrDefault(c => c.Path == image.Path);
                        if (item != null && File.Exists(item.Path))
                        {
                            uow.Context.Image.Remove(item);
                            File.Delete(item.Path);
                        }
                    }
                }
                if (motorbikeEntry != null)
                {
                    foreach (var image in request.Images)
                    {
                        var item = motorbikeEntry.Image.FirstOrDefault(c => c.Path == image.Path);
                        if (item != null && File.Exists(item.Path))
                        {
                            uow.Context.Image.Remove(item);
                            File.Delete(item.Path);
                        }
                    }
                }
                uow.Commit();
                return Unit.Value;
            }
        }
    }
}
