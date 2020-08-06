using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.MotorbikeService.Commands
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public Command(Guid Id)
            {
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
                var DbEntry = uow.MotorbikeRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"Motorbike by Id {request.Id} Not found in database");
                }
                var accessToken = uow.httpContextAccessor.HttpContext.User.Identity.Name;
                Guid id;
                if (!Guid.TryParse(accessToken, out id))
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "guid has bad structure");
                }
                if (id != DbEntry.UserId)
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, "Unauthorized access");
                }
                if (Directory.Exists(Directory.GetCurrentDirectory() + @"\Images\" + request.Id))
                {
                    Directory.Delete(Directory.GetCurrentDirectory() + @"\Images\" + request.Id, true);
                }
                uow.MotorbikeRepository.Delete(DbEntry);
                uow.Commit();
                return Unit.Value;
            }
        }
    }
}
