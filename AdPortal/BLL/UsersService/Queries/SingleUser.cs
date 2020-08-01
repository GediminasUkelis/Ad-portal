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

namespace BLL.UsersService.Queries
{
    public class SingleUser
    {
        public class Query : IRequest<UserDto>
        {
            public Query(string username)
            {
                this.username = username;
            }
            public string username { get; set; }
        }
        public class Handler : IRequestHandler<Query, UserDto>
        {
            private readonly IUnitOfWork uow;

            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<UserDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var found = uow.User.FindSingleUser(request.username);
                if (found == null)
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"This username -  {request.username} does not exists!");
                var User = uow.Mapper.Map<UserDto>(found);
                return User;

            }
        }
    }
}
