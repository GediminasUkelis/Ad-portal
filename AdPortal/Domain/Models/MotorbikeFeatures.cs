using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class MotorbikeFeatures
    {
        public int MotorbikeId { get; set; }
        public Motorbike Motorbike { get; set; }
        public int FeatureId { get; set; }
        public Features Feature { get; set; }
    }
}
