using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningExtra3a
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 3a

            //Maak een applicatie waarbij je een getal kunt invoeren.
            //Het programma moet de tafel van dat getal weergeven.De eerste 10 vermenigvuldigingen komen onder elkaar te staan. Maak gebruik van een lus!
            Console.Write("Geef een nummer in: ");
            int getal = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= 10; i++)
            {
                Console.WriteLine(getal*i);
            }
            Console.ReadKey();
        }
    }
}
