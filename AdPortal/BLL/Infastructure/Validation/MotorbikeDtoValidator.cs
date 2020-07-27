using BLL.Dto;
using FluentValidation;

namespace BLL.Infastructure.Validation
{
    public class MotorbikeDtoValidator : AbstractValidator<MotorbikeDto>
    {
        public MotorbikeDtoValidator()
        { 
            RuleFor(c => c.Manufacturer).NotEmpty().WithMessage("Please specify a manufacturer");
                When(x => x.Manufacturer != null, () =>
                {
                    RuleFor(x => x.Manufacturer.Name).NotEmpty().WithMessage("Manufacturer cannot be empty");
                });
            RuleFor(c => c.Category).NotEmpty().WithMessage("Please specify the Category");
                When(x => x.Category != null, () =>
                {
                    RuleFor(x => x.Category.Name).NotEmpty().WithMessage("Category cannot be empty");
                });
            RuleFor(c => c.Condition).NotEmpty().WithMessage("Please specify the Condition");
                When(x => x.Condition != null, () =>
                {
                    RuleFor(x => x.Condition.VehicCondition).NotEmpty().WithMessage("Vehicle condition cannot be empty");
                });
            RuleFor(c => c.ManufactureDate).NotEmpty().WithMessage("Please specify manufacture date");
            RuleFor(c => c.VehicleType).NotEmpty().WithMessage("Please specify the vehicle type");
                When(x => x.VehicleType != null, () =>
                {
                    RuleFor(x => x.VehicleType.Type).NotEmpty().WithMessage("Vehicle type cannot be empty");
                });
            RuleFor(c => c.EngineCapacity).NotEmpty().WithMessage("Please specify engine capacity");
            RuleFor(c => c.FuelType).NotEmpty().WithMessage("Please specify the fuel type");
                When(x => x.FuelType != null, () =>
                {
                    RuleFor(x => x.FuelType.Type).NotEmpty().WithMessage("Fuel type cannot be empty");
                });
            RuleFor(c => c.TireWearOut).NotEmpty().WithMessage("Please specify tire wear out percentage");
            RuleFor(c => c.Power).NotEmpty().WithMessage("Please specify the Power");
            RuleFor(c => c.Cooling).NotEmpty().WithMessage("Please specify Cooling type");
                When(x => x.Cooling != null, () =>
                {
                    RuleFor(x => x.Cooling.CoolingType).NotEmpty().WithMessage("Cooling type cannot be empty");
                });
            RuleFor(c => c.Defects).NotEmpty().WithMessage("Please specify Defects");
            When(x => x.Defects!= null, () =>
            {
                RuleFor(x => x.Defects.Defect).NotEmpty().WithMessage("Defects cannot be empty");
            });
            RuleFor(c => c.Registration).Must(x=>x== false || x== true).WithMessage("Please specify Registration");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Please specify Description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Please specify Price");
        }
    }
}
