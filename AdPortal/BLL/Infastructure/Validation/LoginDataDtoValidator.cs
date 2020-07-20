using BLL.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.Validation
{
    public class LoginDataDtoValidator : AbstractValidator<LoginDataDto>
    {
        public LoginDataDtoValidator()
        {
            RuleFor(c => c.Username).NotEmpty().WithMessage("Please specify the Username");
            RuleFor(c => c.Password).NotEmpty().WithMessage("Please specify the Password");
        }
    }
}
