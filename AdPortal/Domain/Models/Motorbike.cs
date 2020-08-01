using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Motorbike : BaseModel
    {
        public Manufacturer Manufacturer { get; set; }
        public Category Category { get; set; }
        public Condition Condition { get; set; }
        public DateTime ManufactureDate { get; set; }
        public VehicleType VehicleType { get; set; }
        public int EngineCapacity { get; set; }
        public FuelType FuelType { get; set; }
        public decimal TireWearOut { get; set; }
        public int Power { get; set; }
        public Cooling Cooling { get; set; }
        public Defects Defects { get; set; }
        public bool Registration { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
