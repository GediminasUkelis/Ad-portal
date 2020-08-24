using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class BikeDetails : BaseModel
    {
        public Enumerators.BikeType BikeType { get; set; }
        public Guid VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
