using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Som
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schrijf een consoleapplicatie die de som van twee ingegeven getallen berekent en de uitkomst toont op het scherm. Wat gebeurt er als je een letter ingeeft? Hoe vangen we dit op? Pas dit ook toe op je oplossing.
            try
            {
                Console.WriteLine("Geef het eerste getal in: ");
                int getal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Geef het tweede getal in: ");
                int getal2 = int.Parse(Console.ReadLine());
                int som = getal1 + getal2;

                Console.WriteLine("De som van beide getallen is: " + som);
                Console.ReadKey();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Je gaf een andere waarde dan een getal in!");
                Console.ReadKey();

            }

        }
    }
}
