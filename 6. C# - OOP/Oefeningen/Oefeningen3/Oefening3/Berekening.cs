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
         *  1, 1, 2, 3, 5, 8, 13, 21, 34, 55
         */
        public int Fibonacci(int aantal)
        {
            int startwaarde = 1;
            int waarde1 = 1;
            int waarde2 = 1;
            int tussenSom = waarde1 + waarde2;
            //als aantal 0 is dan is de return 0
            if (aantal == 0)
            {                
                return aantal+1;
            }
            int berekening = 0 + startwaarde;

            int fibo = Fibonacci(aantal - 1);
            int waarde = startwaarde + fibo;
            Console.WriteLine("RESULTAAT Stap " + aantal + " " + waarde + " " + startwaarde + " " + fibo);
            aantal--;
            return waarde;
        }
    }
}
