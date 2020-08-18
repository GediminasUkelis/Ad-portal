using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL.CarService.Queries
{
    public class List
    {
        public class Query : IRequest<List<VehicleDto>>
        {
            public Query()
            {

            }
        }
        public class Handler : IRequestHandler<Query, List<VehicleDto>>
        {
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<List<VehicleDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                List<VehicleDto> carVehicle = new List<VehicleDto>();
                var DbEntry = await uow.CarRepository.GetAll();
                foreach (var item in DbEntry)
                {
                    carVehicle.Add(uow.Mapper.Map<VehicleDto>(item));
                }
                return carVehicle;
            }
        }
    }
}
