using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Domain.Models
{
    public class CarImage : BaseModel
    {
        public string Path { get; set; }
        public Guid CarId { get; set; }
        public Car Cars { get; set; }
    }
    public class MotorbikeImage : BaseModel
    {
        public string Path { get; set; }
        public Guid MotorbikeId { get; set; }
        public Motorbike Motorbikes { get; set; }
    }
    public class TireImage : BaseModel
    {
        public string Path { get; set; }
        public Guid TireId { get; set; }
        public Tire Tires { get; set; }
    }

}
