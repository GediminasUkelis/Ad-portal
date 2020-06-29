using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Cooling : BaseModel
    {
        [DataMember]
        public string CoolingType { get; set; }
    }
}