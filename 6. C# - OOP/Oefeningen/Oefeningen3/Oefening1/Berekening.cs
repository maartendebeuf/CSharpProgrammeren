using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Berekening
    {
        public int Som(int startwaarde, int aantal)
        {   
            
            if (aantal ==0)
            {
                Console.WriteLine("EINDE");
                return startwaarde;
            }
            int som = startwaarde + startwaarde;
            aantal--;
            Console.WriteLine("RESULTAAT Stap " + aantal + " " + som);
            int resultaat = Som(som, aantal);

            return resultaat;
        }
    }
}
