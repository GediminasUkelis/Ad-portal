using BLL.Dto;
using BLL.Infastructure;
using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Features.CarService.Commands
{
    public class Put
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
                var obj = uow.Mapper.Map<Car>(request.obj);
                uow.carRepository.Update(obj);
                uow.Commit();
                return Unit.Value;
            }
            

           
        }
    }
}
