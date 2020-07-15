using BLL.Dto;
using FluentValidation;

namespace BLL.Infastructure.Validation
{
    public class MotorbikeDtoValidator : AbstractValidator<MotorbikeDto>
    {
        public MotorbikeDtoValidator()
        { 
            RuleFor(c => c.Manufacturer).NotEmpty().WithMessage("Please specify a manufacturer");
            RuleFor(c => c.Category).NotEmpty().WithMessage("Please specify the Category");
            RuleFor(c => c.Condition).NotEmpty().WithMessage("Please specify the Condition");
            RuleFor(c => c.ManufactureDate).NotEmpty().WithMessage("Please specify manufacture date");
            RuleFor(c => c.VehicleType).NotEmpty().WithMessage("Please specify the vehicle type");
            RuleFor(c => c.EngineCapacity).NotEmpty().WithMessage("Please specify engine capacity");
            RuleFor(c => c.FuelType).NotEmpty().WithMessage("Please specify the fuel type");
            RuleFor(c => c.TireWearOut).NotEmpty().WithMessage("Please specify tire wear out percentage");
            RuleFor(c => c.Power).NotEmpty().WithMessage("Please specify the Power");
            RuleFor(c => c.Cooling).NotEmpty().WithMessage("Please specify Cooling type");
            RuleFor(c => c.Defects).NotEmpty().WithMessage("Please specify Defects");
            RuleFor(c => c.Registration).NotEmpty().WithMessage("Please specify Registration");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Please specify Description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Please specify Price");
        }
    }
}
