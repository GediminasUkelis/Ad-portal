using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Product : BaseModel
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<Image> Image { get; set; }
        public Enumerators.Condition Condition { get; set; }
    }
}
