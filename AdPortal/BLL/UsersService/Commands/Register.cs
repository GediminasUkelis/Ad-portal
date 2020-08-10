using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.Handler;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.UsersService.Commands
{
    public class Register
    {
        public class Command : IRequest
        {
            public Command(RegisterDto obj)
            {
                this.obj = obj;
            }
            public RegisterDto obj { get; set; }
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
                if(await uow.Context.Users.SingleOrDefaultAsync(x=>x.Username==request.obj.Username)!=null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"User with this {request.obj.Username} already exists");
                }

                RegisterDtoValidation validator = new RegisterDtoValidation();
                ValidationResult results = validator.Validate(request.obj);

                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(request.obj);
                }

                var salt = Salt.Create();
                request.obj.Password = Hash.Create(request.obj.Password, salt);
                var obj = uow.Mapper.Map<User>(request.obj);
                obj.Salt = salt;
                obj.Role = Role.User;
                await uow.User.RegisterAsync(obj);
                uow.Commit();
                return Unit.Value;

            }
        }
    }
}
