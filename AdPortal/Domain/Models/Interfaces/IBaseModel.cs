using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IBaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
