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
        public string Naam { get; }
        public int Leeftijd { get; }
        public string Geslacht { get; }
        public abstract string Type { get; }

        public Dier(string naam, int leeftijd, string geslacht)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Geslacht = geslacht;
        }

        public abstract void PrintGeluid();
    }
}
