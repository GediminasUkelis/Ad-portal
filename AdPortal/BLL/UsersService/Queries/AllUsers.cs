using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.UsersService.Queries
{
    public class AllUsers
    {
        public class Query : IRequest<List<UserDto>>
        {
            public Query()
            {

            }
        }
        public class Handler : IRequestHandler<Query, List<UserDto>>
        {
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<List<UserDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                List<UserDto> Users = new List<UserDto>();
                var DbEntry = uow.UserRepository.GetAll();
                foreach (var item in DbEntry)
                {
                    Users.Add(uow.Mapper.Map<UserDto>(item));
                }
                return Users;
            }


        }
    }
}
