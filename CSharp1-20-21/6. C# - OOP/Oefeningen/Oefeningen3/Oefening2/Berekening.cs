using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    class Berekening
    {
        /*
         * Schrijf een recursieve methode die de faculteit van een gegeven getal berekent. Doe dit door middel van recursie.
         * Vb: 5! = 5 x 4 x 3 x 2 x 1 = 120​
         */
        public int Faculteit(int startwaarde)
        {
            //als startwaarde 1 is dan is de uitkomst 1
            if (startwaarde <=1)
            {
                Console.WriteLine("EINDE");
                return startwaarde;
            }
            //als startwaarde 2 is dan wordt deze vermenigvuldigd met 2-1 wat 1 zal returnen
            int waarde = startwaarde * Faculteit(startwaarde-1);
            //startwaarde aftellen
            startwaarde--;
            Console.WriteLine("RESULTAAT Stap " + startwaarde + " " + waarde);

            return waarde;
        }
    }
}
