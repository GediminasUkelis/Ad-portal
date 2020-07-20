using System;
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
       
    }
}
