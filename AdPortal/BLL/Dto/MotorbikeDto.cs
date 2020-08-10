using Domain.Models;
using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Dto
{
    public class MotorbikeDto : BaseModelDto
    {
        public string Manufacturer { get; set; }
        public string ManufacturerModel { get; set; }

        public Enumerators.Category Category { get; set; }
        public Enumerators.Condition Condition { get; set; }
        public DateTime ManufactureDate { get; set; }
        public Enumerators.BikeType BikeType { get; set; }
        public short EngineCapacity { get; set; }
        public Enumerators.Fuel Fuel { get; set; }
        public float TireWearOut { get; set; }
        public short Power { get; set; }
        public Enumerators.Cooling Cooling { get; set; }
        public string Defects { get; set; }
        public bool Registration { get; set; }
        public ICollection<Image> Image { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
      
    }
}
