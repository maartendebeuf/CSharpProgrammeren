using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3_Quiz
{
    public class Lid : Object
    {
        public string Naam { get; set; }
        public string Specialiteit { get; set; }

        // Constructor
        // Iedere parameter start met een kleine letter => camelCasing
        public Lid(string nieuweNaam, string nieuweSpecialiteit)
        {
            Naam = nieuweNaam;
            Specialiteit = nieuweSpecialiteit;
        }
        
        //public string Print()
        //{
        //    return $"Naam: {Naam}, Specialiteit: {Specialiteit}";
        //}        

        public override string ToString()
        {
            return $"Naam: {Naam}, Specialiteit: {Specialiteit}"; 
        }
    }
}
