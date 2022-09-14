using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{//Definieer een interface `IPerson` met eigenschappen voorNaam en Leeftijd. 
    //Definieer een klasse `Inwoner` die `IPerson` implementeert en een constructor heeft die een naam en een leeftijd verwacht.

    interface IPerson
    {
        public string Voornaam { get; }

        public string Naam { get;  }

        public int Leeftijd { get;  }
    }
}
