using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
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
            public MotorbikeDto obj { get; set; }
            public Command(MotorbikeDto obj)
            {
                this.obj = obj;
            }
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

                MotorbikeDtoValidator validator = new MotorbikeDtoValidator();
                ValidationResult results = validator.Validate(request.obj);

                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(request.obj);
                }

                var motorbike = uow.Mapper.Map<Motorbike>(request.obj);
                uow.MotorbikeRepository.Insert(motorbike);
                uow.Commit();
                return Unit.Value;
            }
        }

    }
}
