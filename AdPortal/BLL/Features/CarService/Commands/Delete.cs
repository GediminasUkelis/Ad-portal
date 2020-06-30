using DAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;

namespace BLL.Features.CarService.Commands
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
                var DbEntry = uow.carRepository.GetById(request.Id);
                if (DbEntry != null)
                {
                    uow.carRepository.Delete(DbEntry);
                    uow.Commit();
                }
                return Unit.Value;
            }

         
        }
    }
}
