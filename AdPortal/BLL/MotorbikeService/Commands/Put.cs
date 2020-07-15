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

namespace BLL.MotorbikeService.Commands
{
    public class Put
    {
        public class Command : IRequest
        {
            public MotorbikeDto obj { get; set; }
            public Guid Id{ get; set; }
            
            public Command(MotorbikeDto obj, Guid Id)
            {
                this.obj = obj;
                this.Id = Id;
            }
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
                if (request.obj == null)
                {
                    throw new StatusCodeException(HttpStatusCode.BadRequest, $" Object is empty");
                }
                var DbEntry = uow.MotorbikeRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound,$"Motorbike with id {request.Id} not found");
                }
                uow.Mapper.Map(request.obj, DbEntry);
                uow.MotorbikeRepository.Update(DbEntry);
                uow.Commit();
                return Unit.Value;
            }
        }

    }
}
