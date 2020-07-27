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

            RuleFor(c => c.Category).NotEmpty().WithMessage("Please specify the Category");
                When(x => x.Category != null, () =>
                {
                    RuleFor(x => x.Category.Name).NotEmpty().WithMessage("name cannot be empty");
                });
            RuleFor(c => c.Manufacturer).NotEmpty().WithMessage("Please specify the Manufacturer");
            When(x => x.Manufacturer != null, () =>
            {
                RuleFor(x => x.Manufacturer.Name).NotEmpty().WithMessage("manufacturer cannot be empty");
            });
            RuleFor(c => c.ManufacturerModel).NotEmpty().WithMessage("Please specify the Manufacturer Model");
            When(x => x.ManufacturerModel != null, () =>
            {
                RuleFor(x => x.ManufacturerModel.Name).NotEmpty().WithMessage("Model cannot be empty");
            });
            RuleFor(c => c.ManufactureDate).NotEmpty().WithMessage("Please specify a date");
            RuleFor(c => c.Seats).NotEmpty().WithMessage("Please specify seats");
            RuleFor(c => c.SteeringWheelPos).NotEmpty().WithMessage("Please specify steering wheel position");
            When(x => x.SteeringWheelPos != null, () =>
            {
                RuleFor(x => x.SteeringWheelPos.Position).NotEmpty().WithMessage("Steering wheel position cannot be empty");
            });
            RuleFor(c => c.Transmission).NotEmpty().WithMessage("Please specify transmission type");
            When(x => x.Transmission != null, () =>
            {
                RuleFor(x => x.Transmission.Type).NotEmpty().WithMessage("transmission cannot be empty");
            });
            RuleFor(c => c.VehicleInspection).NotEmpty().WithMessage("Please specify vehicle inspection date");
            RuleFor(c => c.Color).NotEmpty().WithMessage("Please specify a color");
            When(x => x.Color != null, () =>
            {
                RuleFor(x => x.Color.Name).NotEmpty().WithMessage("color cannot be empty");
            });
            RuleFor(c => c.Defects).NotEmpty().WithMessage("Please specify defects");
            When(x => x.Defects != null, () =>
            {
                RuleFor(x => x.Defects.Defect).NotEmpty().WithMessage("Defect cannot be empty");
            });
            RuleFor(c => c.Doors).NotEmpty().WithMessage("Please specify door count");
            When(x => x.Doors != null, () =>
            {
                RuleFor(x => x.Doors.DoorCount).NotEmpty().WithMessage("Doors count cannot be empty");
            });
            RuleFor(c => c.Engine).NotEmpty().WithMessage("Please specify engine");
            RuleFor(c => c.FrameType).NotEmpty().WithMessage("Please specify frame type");
            When(x => x.FrameType != null, () =>
            {
                RuleFor(x => x.FrameType.Type).NotEmpty().WithMessage("frame type cannot be empty");
            });
            RuleFor(c => c.FuelType).NotEmpty().WithMessage("Please specify fuel type");
            When(x => x.FuelType != null, () =>
            {
                RuleFor(x => x.FuelType.Type).NotEmpty().WithMessage("fuel type cannot be empty");
            });
            RuleFor(c => c.Description).NotEmpty().WithMessage("Please specify description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Please specify price");
        }
    }
}
