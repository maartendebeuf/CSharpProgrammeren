using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Program
    {
        static void Main(string[] args)
        {

            //### Oefening 5
            //Maak een applicatie die een aantal getallen vraagt. Toon enkel de oneven getallen. Maak gebruik van een foreach!
            int aantal = 5;
            int[] getallen = new int[aantal];
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine("geef getal" + (i +1) + " in: ");
                getallen[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < aantal; i++)
            {
                if(getallen[i]%2.0 != 0)
                {
                    Console.Write(getallen[i] + ", ");
                }

            }
            Console.ReadLine();
        }
    }
}
