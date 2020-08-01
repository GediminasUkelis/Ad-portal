using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
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
                this.Username = username;
            }
            public string Username { get; set; }
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
                var found = uow.User.FindSingleUser(request.Username);
                if (found == null)
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"This username -  {request.Username} does not exists!");
                var UserCars = uow.CarRepository.GetAll();
                List<CarDto> carDtos = new List<CarDto>();
                foreach (var item in UserCars)
                {
                    if(item.User!=null)
                    {
                        if (item.User.Id == found.Id)
                        {
                            carDtos.Add(uow.Mapper.Map<CarDto>(item));
                        }
                    }
                }
                var User = uow.Mapper.Map<UserDto>(found);
                User.Cars = carDtos;
                return User;

            }
        }
    }
}
