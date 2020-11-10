using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 2
            //Maak een applicatie die vijf namen vraagt en de namen daarna in omgekeerde volgorde toont.

            string[] namen = new string[5];
            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write("Geef naam " + (i + 1) + ":");
                var input = Console.ReadLine();
                namen[i] = input;
            }
            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write(namen[namen.Length-(i+1)] + ", ");
            }
            Console.ReadLine();
        }
    }
}
