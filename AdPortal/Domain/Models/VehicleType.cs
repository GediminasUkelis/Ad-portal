

namespace Domain.Models
{
    public class VehicleType : BaseModel
    {
        public string Type { get; set; }
        public Category Category { get; set; }
        
    }
}