using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat een tekst naar enkel kleine letters omzet.

            Console.WriteLine("Geef een woord in: ");
            string woord = Console.ReadLine();
            Console.Write(".ToLower: " + woord.ToLower());
            Console.ReadKey();
        }
    }
}
