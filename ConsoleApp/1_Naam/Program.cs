using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Naam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vraag een naam en toon die daarna aan de gebruiker.
            Console.WriteLine("Voer uw naam in:");
            Console.WriteLine("Jij heet " + Console.ReadLine() + " ;)");
            Console.ReadKey();
        }
    }
}
