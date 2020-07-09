﻿using AutoMapper;
using BLL.CarService.Queries;
using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
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
            public Command(Guid Id, CarDto obj)
            {
                this.obj = obj;
                this.Id = Id;
            }
            public Guid Id { get; set; }
            public CarDto obj { get; set; }
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
                var DbEntry = uow.carRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "was not found in database", request.Id);
                }

                uow.Mapper.Map(request.obj, DbEntry);
                
                uow.carRepository.Update(DbEntry);
                uow.Commit();
                return Unit.Value;
            }
        }
    }
}