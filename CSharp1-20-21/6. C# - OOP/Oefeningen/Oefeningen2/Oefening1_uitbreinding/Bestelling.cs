using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1_uitbreinding
{
    class Bestelling
    {
        //Ontwerp een applicatie om een bestelling te verwerken.\
        //Te bewaren in een object:
        //* Naam besteld artikel
        //* Eenheidsprijs artikel
        //* Aantal bestelde artikelen
        //* Totaalprijs bestelling

        //    Werk met methodes en/of properties. Toon als laatste een overzicht van de bestelling (product, aantal, eenheidsprijs en totaalprijs).

        //** Uitbreiding**: Voorzie dat je een lijst met bestellingen kan toevoegen, opslaan en weergeven.
        public string ArtikelNaam { get; set; }
        public int Eenheidsprijs { get; set; }
        public int AantalArtikelen { get; set; }
        public int Totaalprijs
        {
            get
            {
                return (Eenheidsprijs * AantalArtikelen);
            }
        }       
    }
}
