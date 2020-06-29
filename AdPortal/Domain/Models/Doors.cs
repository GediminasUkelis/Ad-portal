using System.Runtime.Serialization;
using System.Security.Policy;

namespace Domain.Models
{
    public class Doors : BaseModel
    {
        [DataMember]
        public string DoorCount { get; set; }
    }
}