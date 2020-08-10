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

namespace BLL.MotorbikeService.Queries
{
    public class GetById
    {
        public class Query : IRequest<MotorbikeDto>
        {
            public Guid Id{ get; set; }
            public Query(Guid Id)
            {
                this.Id = Id;
            }
        }
        public class Handler : IRequestHandler<Query, MotorbikeDto> {

            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }

            public async Task<MotorbikeDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var DbEntry = await uow.MotorbikeRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"Motorbike with this {request.Id} was not found in database");
                }
                var motorbikeDto = uow.Mapper.Map<MotorbikeDto>(DbEntry);
                return motorbikeDto;
            }
        }

    }
}
