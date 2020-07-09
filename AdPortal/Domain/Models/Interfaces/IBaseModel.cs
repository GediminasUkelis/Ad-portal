using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
  
    public interface IBaseModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
