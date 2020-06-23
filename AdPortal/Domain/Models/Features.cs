using System.Collections.Generic;

namespace Domain.Models
{
    public class Features : BaseModel
    {
        public string Name { get; set; }
        public ICollection<MotorbikeFeatures> MotorbikeFeatures { get; set; }
        public ICollection<CarFeatures> CarFeatures { get; set; }

    }
}