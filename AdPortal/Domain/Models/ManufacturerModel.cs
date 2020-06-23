using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ManufacturerModel : BaseModel
    {
        public string Name { get; set;}
        public Manufacturer Manufacturer { get; set; }
    }
}
