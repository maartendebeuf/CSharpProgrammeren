using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2
{
    //Gebruik de code van de vorige oefening om een interface `IIdentifiable` te maken met een eigenschap string `Id` 
    //en een interface `IBirthable` met een eigenschap DateTime `Geboortedatum` en 
    //deze te implementeren in onze `Inwoner` klasse . Herschrijf de constructor met die nieuwe parameters.
    class Inwoner : IPerson, IBirthable
    {
        public string Voornaam { get ; set; }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Guid Id { get; set; }
        public DateTime Geboortedatum { get; set; }

        public Inwoner(string voornaam, string naam, int leeftijd, Guid id, DateTime geboortedatum)
        {
            Voornaam = voornaam;
            Naam = naam;
            Leeftijd = leeftijd;
            Id = id;
            Geboortedatum = geboortedatum;

        }
    }
}
