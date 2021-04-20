using System;
using System.Collections.Generic;
using System.Text;
using Uno;

namespace Oefening2
{
    //Gebruik de code van de vorige oefening om een interface `IIdentifiable` te maken met een eigenschap string `Id` 
    //en een interface `IBirthable` met een eigenschap DateTime `Geboortedatum` en 
    //deze te implementeren in onze `Inwoner` klasse . Herschrijf de constructor met die nieuwe parameters.
    interface IPerson : IIdentifiable
    {
        public string Voornaam { get; set; }

        public string Naam { get; set;  }

        public int Leeftijd { get; set;  }
    }
}
