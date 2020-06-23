using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Domain.Models
{
    public class CarFeatures
    {
       
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int FeatureId { get; set; }
        public Features Feature { get; set; }
    }
}
