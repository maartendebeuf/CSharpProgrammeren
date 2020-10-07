using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_VoorEnFamilieNaam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schrijf een consoleapplicatie die gebruik maakt van twee variabelen (firstname, lastname) die reeds geïnitializeerd zijn en toon de waardes als één lijn op het scherm. Pas daarna via input van de gebruiker beide variabelen aan en toon de volledige naam op het scherm.
            string voornaam = "voornaam";
            string familienaam = "familienaam";

            Console.WriteLine("Voer uw " + voornaam + " in:");
            voornaam = Console.ReadLine();
            Console.WriteLine("Voer uw " + familienaam + " in:");
            familienaam = Console.ReadLine();
            Console.WriteLine("Jij heet " + voornaam + " " + familienaam + " ;)");
            Console.ReadKey();
        }
    }
}
