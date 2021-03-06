﻿using BLL.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.Validation
{
    public class CarVehicleDtoValidation : AbstractValidator<VehicleDto>
    {
        public CarVehicleDtoValidation()
        {
            RuleFor(c => c.Manufacturer).NotEmpty().WithMessage("Please specify the Manufacturer");
            RuleFor(c => c.ManufacturerModel).NotEmpty().WithMessage("Please specify the Manufacturer Model");
            RuleFor(c => c.ManufactureDate).NotEmpty().WithMessage("Please specify a date");
            RuleFor(c => c.Registration).NotEmpty().WithMessage("Please specify a if Vehicle is Registered");
            RuleFor(c => c.Engine).NotEmpty().WithMessage("Please specify engine");
            RuleFor(c => c.Category).NotNull().WithMessage("Please specify the Category");
            RuleFor(c => c.Frame).NotNull().WithMessage("Please specify frame type");
            RuleFor(c => c.Fuel).NotNull().WithMessage("Please specify fuel type");
            RuleFor(c => c.Cooling).NotNull().WithMessage("Please specify the Cooling");
            RuleFor(c => c.Transmission).NotNull().WithMessage("Please specify transmission type");
            RuleFor(c => c.Color).NotEmpty().WithMessage("Please specify a color");
            RuleFor(c => c.VehicleInspection).NotEmpty().WithMessage("Please specify vehicle inspection date");
            RuleFor(c => c.Defects).NotNull().WithMessage("Please specify defects");
            RuleFor(c => c.TireWearOut).NotEmpty().WithMessage("Please specify the tire wearout");
            RuleFor(c => c.Power).NotEmpty().WithMessage("Please specify the power");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Please specify description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Please specify price");
            RuleFor(c => c.Condition).NotNull().WithMessage("Please specify condition");
            RuleFor(c => c.CarDetails).NotEmpty().WithMessage("Please specify car details");
            When(c => c.CarDetails != null, () =>
            {
                RuleFor(c => c.CarDetails.SteeringWheelPos).NotNull().WithMessage("Please specify steering wheel position");
                RuleFor(c => c.CarDetails.Seats).NotEmpty().WithMessage("Please specify car seats");
                RuleFor(c => c.CarDetails.Doors).NotEmpty().WithMessage("Please specify car doors");
            });
        }
    }
}
