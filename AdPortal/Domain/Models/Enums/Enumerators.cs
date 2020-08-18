using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Enums
{
    public class Enumerators
    {
        public enum Fuel
        {
            Benzinas,
            Dyzelinas,
            Dujos
        }
        public enum Defects
        {
            skendes, 
            deges, 
            be
        }
       public enum Frame
        {
           Universalas,
           Sedanas,
           Hecbekas
        }
        public enum Transmission
        {
            Mechaninė,
            Automatinė
        }
        public enum BikeType
        {
            Krosinis,
            Enduro,
            Kelioninis,
            Cioperis,
            Keturratis
        }
        public enum Category
        {
            Automobilis,
            Motociklas,
            Traktorius
        }
        public enum Condition
        {
            Nuajas,
            Naudotas,
            Daužtas
        }
        public enum Cooling
        {
            Oru,
            Vandeniu,
            Tepalu
        }
    }
}
