using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Image : BaseModel
    {
        public string Path { get; set; }
        public Guid CarId { get; set; }
        public Car Cars { get; set; }
    }
}
