namespace BLL.Dto
{
    public class CarDetailsDto :BaseModelDto
    {
        public bool SteeringWheelPos { get; set; }
        public sbyte Seats { get; set; }
        public sbyte Doors { get; set; }
    }
}