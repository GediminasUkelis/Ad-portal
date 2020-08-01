﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Name { get; set; }
        //public string Surname { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
        public ICollection<Car> Cars { get; set; }
        public ICollection<Motorbike> Motorbikes { get; set; }
        public ICollection<Tire> Tires { get; set; }
    }
}
