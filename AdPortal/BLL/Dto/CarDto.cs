using BLL.Infastructure.Validation;
using Domain.Models;
using Domain.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Dto
{
    public class CarDto : BaseModelDto
    {
        public Enumerators.Category Category { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerModel { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Engine { get; set; }
        public Enumerators.Frame Frame { get; set; }
        public Enumerators.Fuel Fuel { get; set; }
        public string Color { get; set; }
        public Enumerators.Transmission Transmission { get; set; }
        public Enumerators.Condition Condition { get; set; }
        public string Defects { get; set; }
        public bool SteeringWheelPos { get; set; }
        public char Doors { get; set; }
        public sbyte Seats { get; set; }
        public DateTime VehicleInspection { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<ImageDto> Image { get; set; }
      
    }
}
