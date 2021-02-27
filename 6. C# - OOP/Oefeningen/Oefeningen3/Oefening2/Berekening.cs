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

            if (startwaarde == 0)
            {
                Console.WriteLine("EINDE");
                return startwaarde;
            }
            startwaarde--;
            int waarde = Faculteit(startwaarde);

            return waarde;
        }
    }
}
