using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Width : BaseModel
    {
        [DataMember]
        public decimal TireWidth { get; set; }
    }
}