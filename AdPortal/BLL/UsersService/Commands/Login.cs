using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.Handler;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.UsersService.Commands
{
    public class Login
    {
        public class Command : IRequest<string>
        {
            public Command(LoginDataDto obj)
            {
                this.obj = obj;
            }
            public LoginDataDto obj { get; set; }
        }

        public class Handler : IRequestHandler<Command, string>
        {
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }

            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                LoginDataDtoValidator validator = new LoginDataDtoValidator();
                ValidationResult results = validator.Validate(request.obj);

                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(request.obj);
                }
                var User = uow.Context.Users.SingleOrDefault(x => x.Username == request.obj.Username);
                if (User == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"User with this {request.obj.Username} doesn't exists");
                }
                if (!Validation.Validate(request.obj.Password, User.Salt, User.Password))
                {
                    throw new StatusCodeException(HttpStatusCode.Unauthorized, $"User password is incorrect");
                }
                JwtTokenHandler handler = new JwtTokenHandler(uow);
                string token = handler.CreateJWTToken(request.obj.Username, request.obj.Password);
                uow.httpContextAccessor.HttpContext.Session.SetString("JwtToken", token);
                return token;

            }
        }

    }
}
