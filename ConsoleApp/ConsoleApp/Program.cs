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
            // Schrijf een programma dat een bepaald getal/karakter vervangt door een andere waarde.

            Console.WriteLine("Geef een zin in: ");
            string woord = Console.ReadLine();            
            Console.WriteLine(woord.Replace(" ", "_"));            
            Console.ReadKey();
        }
    }
}
