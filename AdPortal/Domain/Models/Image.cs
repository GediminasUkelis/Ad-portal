using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Domain.Models
{
    public class Image : BaseModel
    {
        public string Path { get; set; }
        public Guid? CarId { get; set; }
        public Car Car { get; set; }
        public Guid? MotorbikeId { get; set; }
        public Motorbike Motorbike { get; set; }
        public Guid? TireId { get; set; }
        public Tire Tire { get; set; }
    } 
}
