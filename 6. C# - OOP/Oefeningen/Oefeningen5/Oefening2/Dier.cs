using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    //* de naam
    //* de leeftijd
    //* het geslacht
    public abstract class Dier
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Geslacht { get; set; }

        public Dier(string naam, int leeftijd, string geslacht)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Geslacht = geslacht;
        }

        public abstract void PrintGeluid();
    }
}
