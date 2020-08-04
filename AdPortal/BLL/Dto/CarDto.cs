﻿using BLL.Infastructure.Validation;
using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Dto
{
    public class CarDto : BaseModelDto
    {
        public Category Category { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ManufacturerModel ManufacturerModel { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public string Engine { get; set; }
        public FuelType FuelType { get; set; }
        public FrameType FrameType { get; set; }
        public Color Color { get; set; }
        public Transmission Transmission { get; set; }
        public Defects Defects { get; set; }
        public SteeringWheelPos SteeringWheelPos { get; set; }
        public Doors Doors { get; set; }
        public int? Seats { get; set; }
        public DateTime? VehicleInspection { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public ICollection<ImageDto> Image { get; set; }
       
    }
}
