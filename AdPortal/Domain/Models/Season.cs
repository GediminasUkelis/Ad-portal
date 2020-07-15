using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Season : BaseModel
    {
        [DataMember]
        public string SeasonName { get; set; }
    }
}