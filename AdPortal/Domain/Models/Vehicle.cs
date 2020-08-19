using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Vehicle : Product 
    {
        public string Manufacturer { get; set; }
        public string ManufacturerModel { get; set; }
        public DateTime ManufactureDate { get; set; }
        public bool Registration { get; set; }
        public short Engine { get; set; }
        public Enumerators.Category Category { get; set; }
        public Enumerators.Frame Frame { get; set; }
        public Enumerators.Fuel Fuel { get; set; }
        public Enumerators.Cooling Cooling { get; set; }
        public Enumerators.Transmission Transmission { get; set; }
        public string Color { get; set; }
        public DateTime VehicleInspection { get; set; }
        public Enumerators.Defects Defects { get; set; }
        public float TireWearOut { get; set; }
        public short Power { get; set; }
        #nullable enable
        public Guid? CarDetailsId { get; set; }
        public CarDetails? CarDetails { get; set; }
        public Guid? BikeDetailsId { get; set; }
        public BikeDetails? BikeDetails { get; set; }
    }
}
