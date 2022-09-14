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
            //als aantal 0 is dan is de return 0
            if (aantal <= 1)
            {    
                           
                return 1;
            }         
            
            int waarde1 = Fibonacci(aantal-1);
            int waarde2 = Fibonacci(aantal-2);
            int resultaat = waarde1 + waarde2;


            Console.WriteLine(waarde2);
            return waarde1 + waarde2;
        }
    }
}
