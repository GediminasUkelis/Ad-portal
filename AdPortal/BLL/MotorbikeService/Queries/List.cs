using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.MotorbikeService.Queries
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
                List<VehicleDto> motorbikeDtos = new List<VehicleDto>();
                var DbEntry = await uow.MotorbikeRepository.GetAll();

                foreach (var entry in DbEntry)
                {
                    motorbikeDtos.Add(uow.Mapper.Map<VehicleDto>(entry));
                }
                return motorbikeDtos;
            }
        }
    }
}
