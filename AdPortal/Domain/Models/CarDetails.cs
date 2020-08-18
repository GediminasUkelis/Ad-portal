namespace Domain.Models
{
    public class CarDetails :BaseModel
    {
        public bool SteeringWheelPos { get; set; }
        public sbyte Seats { get; set; }
        public char Doors { get; set; }
    }
}