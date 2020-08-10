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

            RuleFor(c => c.Category).NotNull().WithMessage("Please specify the Category");
               
            RuleFor(c => c.Manufacturer).NotEmpty().WithMessage("Please specify the Manufacturer");
            RuleFor(c => c.ManufacturerModel).NotEmpty().WithMessage("Please specify the Manufacturer Model");
           
            RuleFor(c => c.ManufactureDate).NotEmpty().WithMessage("Please specify a date");
            RuleFor(c => c.Seats).NotEmpty().WithMessage("Please specify seats");
            RuleFor(c => c.SteeringWheelPos).NotEmpty().WithMessage("Please specify steering wheel position");
           
            RuleFor(c => c.Transmission).NotEmpty().WithMessage("Please specify transmission type");
           
            RuleFor(c => c.VehicleInspection).NotEmpty().WithMessage("Please specify vehicle inspection date");
            RuleFor(c => c.Color).NotEmpty().WithMessage("Please specify a color");
           
            RuleFor(c => c.Defects).NotEmpty().WithMessage("Please specify defects");
           
            RuleFor(c => c.Doors).NotEmpty().WithMessage("Please specify door count");
           
            RuleFor(c => c.Engine).NotEmpty().WithMessage("Please specify engine");
            RuleFor(c => c.Frame).NotNull().WithMessage("Please specify frame type");
         
            RuleFor(c => c.Fuel).NotNull().WithMessage("Please specify fuel type");
            RuleFor(c => c.SteeringWheelPos).Must(x => x == false || x == true).WithMessage("Please specify steering Wheel possition");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Please specify description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Please specify price");
        }
    }
}
