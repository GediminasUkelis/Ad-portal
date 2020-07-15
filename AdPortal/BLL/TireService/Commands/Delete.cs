using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.TireService.Commands
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Command(Guid Id)
            {
                this.Id = Id;
            }
            public Guid Id { get; set; }
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


                var DbEntry = uow.TireRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"Tire with this {request.Id} was not found in database");
                }
                uow.TireRepository.Delete(DbEntry);
                uow.Commit();
                return Unit.Value;

            }


        }
    }
}
