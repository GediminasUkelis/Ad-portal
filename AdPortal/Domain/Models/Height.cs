using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Height : BaseModel
    {
        [DataMember]
        public decimal TireHeight { get; set; }
    }
}