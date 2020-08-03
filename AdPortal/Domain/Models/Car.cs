using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Car : BaseModel
    {
        public Car()
        {
            CreatedOn = DateTime.Now;
        }
        // ismesti visus modelius i bendras

        public Category Category { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ManufacturerModel ManufacturerModel { get; set; }
        [DataType(DataType.Date)]
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
        [DataType(DataType.Date)]
        public DateTime VehicleInspection { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }
        public ICollection<Image> Image { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
