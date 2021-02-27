using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Berekening
    {
        /*
         * ## Oefening 3
         * Schrijf een recursieve methode die de rij van **Fibonacci** weergeeft tot *n* getallen. *n* wordt gevraagd aan de gebruiker.
         */
        public int Fibonacci(int startwaarde)
        {

            if (startwaarde == 0)
            {
                Console.WriteLine("EINDE");
                return startwaarde;
            }
            startwaarde--;
            int waarde = Fibonacci(startwaarde);

            return waarde;
        }
    }
}
