using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._1.Basics.Classes
{
    public class AbstractClass : Werknemer
    {
        public AbstractClass(string voornaam, string naam) : base(voornaam, naam)
        {
        }

        public override double GetLoon()
        {
            throw new NotImplementedException();
        }
    }
    // Dit is de superklasse
    // Alle onderliggende klassen (arbeider, bediende en kaderlid) 
    // hebben beschikking tot alle PUBLIEKE properties en methodes van deze klasse
    // Deze klasse is abstract, want een type 'werknemer' kan geen object zijn.
    public abstract class Werknemer
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }

        public Werknemer(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
        }

        public string GetVolledigeNaam()
        {
            return Voornaam + " " + Naam;
        }

        public abstract double GetLoon();
    }
}
