using System.Runtime.Serialization;

namespace Domain.Models
{
    public class TirePurpose : BaseModel
    {
        [DataMember]
        public string Name { get; set; }

    }
}