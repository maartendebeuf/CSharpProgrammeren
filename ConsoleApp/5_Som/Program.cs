using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Som
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schrijf een consoleapplicatie die twee getallen vraagt en controleert of één van de twee getallen tussen -20 en 125 ligt en print de uitkomst op het scherm.

            Console.WriteLine("Geef het eerste getal in: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef het tweede getal in: ");
            int getal2 = int.Parse(Console.ReadLine());
            if (getal1 > -20 && getal1 < 125 || getal2 > -20 && getal2 < 125)
            {
                int som = getal1 + getal2;
                Console.WriteLine("De som van beide getallen is: " + som);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("zorg dat er ten minste één getal tussen -20 en 125 zit");
                Console.ReadLine();
            }
        }
    }
}
