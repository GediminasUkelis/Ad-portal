﻿using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Commands
{
    public class Delete
    {

        public class Command : IRequest
        {
            public Command(Guid Id)
            {
                this.Id = Id;
            }
            public Guid Id { get; set; }
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


                var DbEntry = uow.CarRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"Car with this {request.Id} was not found in database");
                }
                var accessToken = uow.httpContextAccessor.HttpContext.User.Identity.Name;
                Guid id;
                if (!Guid.TryParse(accessToken, out id))
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "guid has bad structure");
                }
                if (id != DbEntry.UserId)
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "Unauthorized access");
                }

                uow.CarRepository.Delete(DbEntry);
                uow.Commit();
                return Unit.Value;

            }

        
        } 
    }
}
