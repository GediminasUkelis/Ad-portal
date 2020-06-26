using AutoMapper;
using BLL.Infastructure;
using BLL.Services.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.Features.CarService.Queries
{
    public class GetById
    {
        public class Query : IRequest<CarDto>
        {
            public Query(Guid Id)
            {
                this.Id = Id;
            }
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, CarDto>
        {
            private readonly IGenericService<CarDto> carRepository;
            private readonly IMapper mapper;

            public Handler(IGenericService<CarDto> carRepository, IMapper mapper)
            {
                this.carRepository = carRepository ?? throw new ArgumentNullException(nameof(carRepository));
                this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            }
            public async Task<CarDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var DbEntry = carRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    return null;
                }

                return DbEntry;
            }
        }
    }
}
