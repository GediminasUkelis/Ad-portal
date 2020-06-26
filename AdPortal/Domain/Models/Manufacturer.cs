﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Manufacturer : BaseModel
    {
        public string Name { get; set; }
        
        public ICollection<ManufacturerModel> manufacturerModels { get; set; }
    }
}
