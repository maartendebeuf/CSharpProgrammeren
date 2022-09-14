using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Berekening
    {
        //Schrijf een recursieve methode die de som van 1 tot* n* berekent. * n* is een parameter die gevraagd wordt aan de gebruiker.
        
        public int Som(int aantal)
        {            
            int waarde = 1;
            //als aantal 0 is dan is de return 1
            if (aantal == 0)
            {
                Console.WriteLine("EINDE");
                return waarde;
            }
            //aantal aftellen
            aantal--;             
            int resultaat = waarde+Som(aantal);
            
            return resultaat;
        }
    }
}
