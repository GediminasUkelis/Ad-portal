using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Enums
{
    public class Enumerators
    {
        public enum Fuel
        {
            Diesel,
            Gasoline,
            Gas
        }
        public enum Defects
        {
            Drowned,
            Broken,
            Perfect
        }
       public enum Frame
        {
           Sedan,
           Universal,
           Coupe
        }
        public enum Transmission
        {
            Mechanic,
            Automatic
        }
        public enum BikeType
        {
            Enduro,
            Motocross,
            SuperBike
        }
        public enum Category
        {
          Car,
          Motorcycle,
          Tractor
        }
        public enum Condition
        {
            New,
            Used,
            Broken
        }
        public enum Cooling
        {
            Air,
            Water,
            Oil
        }
    }
}
