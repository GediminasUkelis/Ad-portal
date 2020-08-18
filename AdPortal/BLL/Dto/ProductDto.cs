using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Dto
{
    public class ProductDto : BaseModelDto
    {
        public string Description { get; set; }
        public float Price { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<ImageDto> Image { get; set; }
        public Enumerators.Condition Condition { get; set; }
    }
}
