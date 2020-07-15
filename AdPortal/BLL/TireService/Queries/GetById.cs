using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.TireService.Queries
{
    public class GetById
    {
        public class Query : IRequest<TireDto>
        {
            public Query(Guid Id)
            {
                this.Id = Id;
            }
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, TireDto>
        {
            private readonly IUnitOfWork uow;

            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<TireDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var DbEntry = uow.TireRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"Tire with this {request.Id} was not found in database");

                }
                var DbEntryDto = uow.Mapper.Map<TireDto>(DbEntry);
                return DbEntryDto;

            }
        }
    }
}
