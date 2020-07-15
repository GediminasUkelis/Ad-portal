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
        public class Query : IRequest<List<MotorbikeDto>>
        {
            public Query()
            {

            }
        }

        public class Handler : IRequestHandler<Query, List<MotorbikeDto>>
        {

            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<List<MotorbikeDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                List<MotorbikeDto> motorbikeDtos = new List<MotorbikeDto>();
                var DbEntry = uow.MotorbikeRepository.GetAll();

                foreach (var entry in DbEntry)
                {
                    motorbikeDtos.Add(uow.Mapper.Map<MotorbikeDto>(entry));
                }
                return motorbikeDtos;
            }
        }

    }
}
