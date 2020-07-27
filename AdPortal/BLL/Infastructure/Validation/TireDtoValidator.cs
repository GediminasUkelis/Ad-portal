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
            When(x => x.Condition != null, () =>
            {
                RuleFor(x => x.Condition.VehicCondition).NotEmpty().WithMessage("Vehicle condition cannot be empty");
            });
            RuleFor(c => c.Diameter).NotEmpty().WithMessage("Please specify the Diameter");
            When(x => x.Diameter != null, () =>
            {
                RuleFor(x => x.Diameter.TireDiameter).NotEmpty().WithMessage("Tire diameter cannot be empty");
            });
            RuleFor(c => c.Width).NotEmpty().WithMessage("Please specify Width");
            When(x => x.Width != null, () =>
            {
                RuleFor(x => x.Width.TireWidth).NotEmpty().WithMessage("Tire width cannot be empty");
            });
            RuleFor(c => c.Height).NotEmpty().WithMessage("Please specify a height");
            When(x => x.Height != null, () =>
            {
                RuleFor(x => x.Height.TireHeight).NotEmpty().WithMessage("Tire height cannot be empty");
            });
            RuleFor(c => c.Season).NotEmpty().WithMessage("Please specify a tire season");
            When(x => x.Season != null, () =>
            {
                RuleFor(x => x.Season.SeasonName).NotEmpty().WithMessage("Season cannot be empty");
            });
            RuleFor(c => c.TirePurpose).NotEmpty().WithMessage("Please specify purpose of tire");
            When(x => x.TirePurpose != null, () =>
            {
                RuleFor(x => x.TirePurpose.Name).NotEmpty().WithMessage("Tire purpose cannot be empty");
            });
            RuleFor(c => c.ManufactureDate).NotEmpty().WithMessage("Please specify manufacture date");
            RuleFor(c => c.TireWearOut).NotEmpty().WithMessage("Please specify tire wear out percentage");
            RuleFor(c => c.Manufacturer).NotEmpty().WithMessage("Please specify a manufacturer");
            When(x => x.Manufacturer != null, () =>
            {
                RuleFor(x => x.Manufacturer.Name).NotEmpty().WithMessage("Manufacturer cannot be empty");
            });
            RuleFor(c => c.Quantity).NotEmpty().WithMessage("Please specify quantity");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Please specify description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Please specify Price");
            
        }
    }
}
