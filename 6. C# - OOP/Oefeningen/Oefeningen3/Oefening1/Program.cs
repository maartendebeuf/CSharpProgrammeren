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

        //Schrijf een recursieve methode die de som van 1 tot* n* berekent. * n* is een parameter die gevraagd wordt aan de gebruiker.
        static void Main(string[] args)
        {
            Berekening berekening = new Berekening();            
            int uitkomst = berekening.Som( 5);
            Console.WriteLine(uitkomst);
            Console.ReadLine();
        }
        
    }
}
