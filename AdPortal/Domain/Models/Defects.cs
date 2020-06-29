using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Defects : BaseModel
    {
        [DataMember]
        public string Defect { get; set; }
    }
}