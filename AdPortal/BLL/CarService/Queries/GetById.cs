using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Queries
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
            private readonly IUnitOfWork uow;

            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<CarDto> Handle(Query request, CancellationToken cancellationToken)
            {
               var DbEntry = await uow.CarRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"Car with this {request.Id} was not found in database");

                }
                var DbEntryDto = uow.Mapper.Map<CarDto>(DbEntry);
                    return DbEntryDto;
                
            }
        }
    }
}
