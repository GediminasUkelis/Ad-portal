using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.TireService.Queries
{
    public class List
    {
        public class Query : IRequest<List<TireDto>>
        {
            public Query()
            {

            }
        }
        public class Handler : IRequestHandler<Query, List<TireDto>>
        {
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<List<TireDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                List<TireDto> carDtos = new List<TireDto>();
                var DbEntry = uow.TireRepository.GetAll();

                foreach (var item in DbEntry)
                {
                    carDtos.Add(uow.Mapper.Map<TireDto>(item));
                }
                return carDtos;
            }
        }
    }
}
