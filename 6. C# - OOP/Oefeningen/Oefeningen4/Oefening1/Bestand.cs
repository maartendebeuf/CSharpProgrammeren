using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    //## Oefening 1

    //Werk klassen uit zodat aan de volgende beschrijving voldaan wordt:\
    //In een toepassing werken we met objecten die voorstellingen zijn van _bestanden_ of _mappen_.
    //* Een map     heeft een naam en kan worden toegevoegd aan een map.
    //* Een bestand heeft een naam en kan worden toegevoegd aan een map.
    //* Een bestand heeft een type (.pdf, .docx, ...)
    class Bestand : Objects
    {
        public string BestandType { get; set; }

        public Bestand(string naam)
            : base(naam)
        {
        }

    }
}
