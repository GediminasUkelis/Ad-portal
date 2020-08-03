using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Dto
{
    public class MotorbikeDto : BaseModelDto
    {
        public Manufacturer Manufacturer { get; set; }
        public Category Category { get; set; }
        public Condition Condition { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ManufactureDate { get; set; }
        public VehicleType VehicleType { get; set; }
        public int? EngineCapacity { get; set; }
        public FuelType FuelType { get; set; }
        public decimal? TireWearOut { get; set; }
        public int? Power { get; set; }
        public Cooling Cooling { get; set; }
        public Defects Defects { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }
        public bool Registration { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

    }
}
