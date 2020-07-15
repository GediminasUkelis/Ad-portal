using BLL.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.Validation
{
    public class TireDtoValidator : AbstractValidator<TireDto>
    {
        public TireDtoValidator()
        {
            RuleFor(c => c.Condition).NotEmpty().WithMessage("Please specify the Condition");
            RuleFor(c => c.Diameter).NotEmpty().WithMessage("Please specify the Diameter");
            RuleFor(c => c.Width).NotEmpty().WithMessage("Please specify Width");
            RuleFor(c => c.Height).NotEmpty().WithMessage("Please specify a height");
            RuleFor(c => c.Season).NotEmpty().WithMessage("Please specify a tire season");
            RuleFor(c => c.TirePurpose).NotEmpty().WithMessage("Please specify purpose of tire");
            RuleFor(c => c.ManufactureDate).NotEmpty().WithMessage("Please specify manufacture date");
            RuleFor(c => c.TireWearOut).NotEmpty().WithMessage("Please specify tire wear out percentage");
            RuleFor(c => c.Manufacturer).NotEmpty().WithMessage("Please specify a manufacturer");
            RuleFor(c => c.Quantity).NotEmpty().WithMessage("Please specify quantity");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Please specify description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Please specify Price");
            
        }
    }
}
