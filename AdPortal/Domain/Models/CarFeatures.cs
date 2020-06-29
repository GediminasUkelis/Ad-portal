using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace Domain.Models
{
    [DataContract]
    public class CarFeatures
    {
    
        public Guid CarId { get; set; }
 
        public Car Car { get; set; }
        public Guid FeatureId { get; set; }
        [DataMember]
        public Features Feature { get; set; }
    }
}
