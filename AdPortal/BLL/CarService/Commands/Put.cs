using AutoMapper;
using BLL.CarService.Queries;
using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Cqrs.Entities;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Data.Common;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Commands
{
    public class Put
    {
        public class Command : IRequest
        {
            public Command(Guid Id, VehicleDto obj)
            {
                this.obj = obj;
                this.Id = Id;
            }
            public Guid Id { get; set; }
            public VehicleDto obj { get; set; }
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
                if(request.obj == null)
                {
                    throw new StatusCodeException(HttpStatusCode.BadRequest, "Object is empty");
                }
                var DbEntry = await uow.CarRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"Tire with this {request.Id} was not found in database");
                }
                var accessToken = uow.httpContextAccessor.HttpContext.User.Identity.Name;
                Guid id;
                if (!Guid.TryParse(accessToken, out id))
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "guid has bad structure");
                }
                if (DbEntry.UserId != id)
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "Unauthorized access");
                }
                var mappedObj = uow.Mapper.Map(request.obj, DbEntry);
                
                await uow.CarRepository.Update(mappedObj);
                
                uow.Commit();
                return Unit.Value;
            }
        }
    }
}
