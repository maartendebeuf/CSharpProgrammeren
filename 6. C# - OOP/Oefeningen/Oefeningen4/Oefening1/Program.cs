using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Program
    {
        //## Oefening 1

        //Werk klassen uit zodat aan de volgende beschrijving voldaan wordt:\
        //In een toepassing werken we met objecten die voorstellingen zijn van _bestanden_ of _mappen_.
        //* Een map heeft een naam en kan worden toegevoegd aan een andere map.
        //* Een bestand heeft ook een naam en een type (.pdf, .docx, ...)
        //* Een bestand kan worden toegevoegd aan een map.
        static void Main(string[] args)
        {
            Objects o = new Objects("Object");
            string objectnaam =  o.Naam;

            Bestand bestand = new Bestand("Bestand");
            bestand.BestandType = ".rvt";

            Map map = new Map("Map");
            map.ObjectToevoegen(o);
            map.ObjectToevoegen(bestand);
        }
    }
}
