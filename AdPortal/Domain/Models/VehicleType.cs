

using System.Runtime.Serialization;

namespace Domain.Models
{
    public class VehicleType : BaseModel
    {
        [DataMember]
        public string Type { get; set; }
        
    }
}