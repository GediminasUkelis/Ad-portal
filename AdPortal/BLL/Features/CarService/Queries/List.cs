using AutoMapper;
using BLL.Infastructure;
using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Features.CarService.Queries
{
    public class List
    {
        public class Query : IRequest<List<CarDto>>
        {
            public Query()
            {

            }
        }
        public class Handler : IRequestHandler<Query, List<CarDto>>
        {
            private readonly IGenericService<CarDto> carRepository;
            private readonly IMapper mapper;

            public Handler(IGenericService<CarDto> carRepository, IMapper mapper)
            {
                this.carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
                this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            }
            public async Task<List<CarDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var DbEntry = carRepository.GetAll();
                if (DbEntry == null)
                {
                    return null;
                }
                
                return DbEntry;
            }
        }
    }
}
