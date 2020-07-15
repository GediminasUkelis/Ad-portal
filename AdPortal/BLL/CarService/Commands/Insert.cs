using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Commands
{
    public class Insert
    {
        public class Command : IRequest
        {
            public Command(CarDto obj)
            {
                this.obj = obj;
            }
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
                CarDtoValidator validator = new CarDtoValidator();
                ValidationResult results = validator.Validate(request.obj);

                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(request.obj);
                }
                var obj = uow.Mapper.Map<Car>(request.obj);
                uow.CarRepository.Insert(obj);
                uow.Commit();
                return Unit.Value;

            }
        }
    }
}

