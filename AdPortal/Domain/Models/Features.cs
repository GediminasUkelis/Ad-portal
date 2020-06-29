using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Domain.Models
{
    [DataContract]
    public class Features : BaseModel
    {
        [DataMember]
        public string Name { get; set; }
        public ICollection<MotorbikeFeatures> MotorbikeFeatures { get; set; }
        public ICollection<CarFeatures> CarFeatures { get; set; }

    }
}