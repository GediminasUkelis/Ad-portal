using System.Runtime.Serialization;

namespace Domain.Models
{
    public class SteeringWheelPos : BaseModel
    {
        [DataMember]
        public string Position { get; set; }
    }
}