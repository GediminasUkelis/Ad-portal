using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Image : BaseModel
    {
        public string Bytes { get; set; }
        public Car Cars { get; set; }
    }
}
