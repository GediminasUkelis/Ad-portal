using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Tire : BaseModel
    {
        public Condition Condition { get; set; }
        public Diameter Diameter { get; set; }
        public Width Width { get; set; }
        public Height Height { get; set; }
        public Season Season { get; set; }
        public TirePurpose TirePurpose { get; set; }
        public DateTime ManufactureDate { get; set; }
        public decimal TireWearOut { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
