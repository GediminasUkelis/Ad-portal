using BLL.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.Validation
{
    class RegisterDtoValidation : AbstractValidator<RegisterDto>
    {

        public RegisterDtoValidation()
        {
            RuleFor(c => c.Username).NotEmpty().WithMessage("Please specify the Username");
            RuleFor(c => c.Password).NotEmpty().WithMessage("Please specify the Password");
            RuleFor(c => c.Name).NotEmpty().WithMessage("Please specify the Name");
        }
    }
}
