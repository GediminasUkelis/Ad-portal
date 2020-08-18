using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Domain.Models
{
    public class Image : BaseModel
    {
        public string Path { get; set; }
        public Guid ProductId { get; set;}
        public Product Product { get; set; }
    } 
}
