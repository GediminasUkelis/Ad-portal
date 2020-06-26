using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure
{
    public class BaseModelDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
