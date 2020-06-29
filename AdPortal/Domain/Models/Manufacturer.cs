using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Manufacturer : BaseModel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public ICollection<ManufacturerModel> manufacturerModels { get; set; }
    }
}
