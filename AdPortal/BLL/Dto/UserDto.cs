using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dto
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }

    }
}
