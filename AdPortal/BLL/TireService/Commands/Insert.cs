using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.TireService.Commands
{
    public class Insert
    {
        public class Command : IRequest
        {
            public Command(TireDto obj)
            {
                this.obj = obj;
            }
            public TireDto obj { get; set; }
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
                TireDtoValidator validator = new TireDtoValidator();
                ValidationResult results = validator.Validate(request.obj);

                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(request.obj);
                }
                var obj = uow.Mapper.Map<Tire>(request.obj);
                uow.TireRepository.Insert(obj);
                uow.Commit();
                return Unit.Value;

            }
        }
    }
}
