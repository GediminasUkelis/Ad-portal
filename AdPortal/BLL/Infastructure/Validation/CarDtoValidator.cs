using BLL.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.Validation
{
    public class CarDtoValidator : AbstractValidator<CarDto>
    {
        public CarDtoValidator()
        {
            RuleFor(x => x.Price).NotEmpty().WithMessage("Please specify a price");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Please specify a Category");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please specify a description");
        }
    }
}
