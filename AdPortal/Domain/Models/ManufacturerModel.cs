using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    [DataContract]
    public class ManufacturerModel : BaseModel
    {
        [DataMember]
        public string Name { get; set;}
    }
}
