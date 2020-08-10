using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.Handler;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
            private readonly IConfiguration configuration;
            public Handler(IUnitOfWork uow, IConfiguration configuration)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
                this.configuration = configuration;
            }

            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                LoginDataDtoValidator validator = new LoginDataDtoValidator();
                ValidationResult results = validator.Validate(request.obj);

                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(request.obj);
                }
                var User = await uow.Context.Users.SingleOrDefaultAsync(x => x.Username == request.obj.Username);
                if (User == null || !Validation.Validate(request.obj.Password, User.Salt, User.Password))
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "Username and/or password is incorrect");
                }
                JwtTokenHandler handler = new JwtTokenHandler(uow, configuration);
                string token = handler.CreateJWTToken(request.obj.Username, request.obj.Password);
                uow.httpContextAccessor.HttpContext.Session.SetString("JwtToken", token);
                return token;
            }
        }

    }
}
