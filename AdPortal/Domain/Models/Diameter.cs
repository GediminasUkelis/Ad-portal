

using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Diameter : BaseModel
    {
        [DataMember]
       public decimal TireDiameter { get; set; }
    }
}