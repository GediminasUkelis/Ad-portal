using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure
{
    public class CarDto : BaseModelDto
    {
        //public Category Category { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ICollection<CarFeatures> carFeatures { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Engine { get; set; }
        public FuelType FuelType { get; set; }
        public FrameType FrameType { get; set; }
        public Color Color { get; set; }
        public Transmission Transmission { get; set; }
        public Defects Defects { get; set; }
        public SteeringWheelPos SteeringWheelPos { get; set; }
        public Doors Doors { get; set; }
        public int Seats { get; set; }
        public DateTime VehicleInspection { get; set; }
        //public string Description { get; set; }
        //public decimal Price { get; set; }
    }
}
