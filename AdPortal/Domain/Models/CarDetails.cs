using System;

namespace Domain.Models
{
    public class CarDetails :BaseModel
    {
        public bool SteeringWheelPos { get; set; }
        public sbyte Seats { get; set; }
        public sbyte Doors { get; set; }
        public Guid VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}