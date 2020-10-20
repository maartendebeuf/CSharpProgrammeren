using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 1

            //Vraag een leeftijd en afhankelijk van de waarde, toon onderstaande boodschap:
            //*Jonger dan 18: "U bent nog niet volwassen."
            //* Tussen 18 en 25: "U bent een jongvolwassene."
            //* Ouder dan 25: "U bent volwassen."

            Console.WriteLine("Geef uw leeftijd in.");
            int leeftijd = int.Parse(Console.ReadLine());

            if ( leeftijd < 18)
            {
                Console.WriteLine("U bent nog niet volwassen.");
            }
            else if (leeftijd >= 18 || leeftijd <= 25)
            {
                Console.WriteLine("U bent een jongvolwassene.");
            }
            else
            {
                Console.WriteLine("U bent volwassen.");
            }
            Console.ReadKey();

        }
    }
}
