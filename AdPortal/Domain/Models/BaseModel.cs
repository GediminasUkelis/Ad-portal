﻿using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BaseModel : IBaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
