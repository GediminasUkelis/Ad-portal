using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Condition : BaseModel
    {
        [DataMember]
        public string VehicCondition { get; set; }
    }
}
