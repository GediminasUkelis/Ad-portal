using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Color : BaseModel
    {
        [DataMember]
        public string Name { get; set; }
    }
}
