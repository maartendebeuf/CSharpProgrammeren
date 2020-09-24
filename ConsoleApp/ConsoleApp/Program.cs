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
            // Vraag een kommagetal aan en converteer dit naar een geheel getal

            Console.WriteLine("Geef een kommagetal in: ");
            double kommagetal = double.Parse(Console.ReadLine());            
            Console.WriteLine("Je gaf het getal " + kommagetal + " in ;)");
            Console.ReadKey();
        }
    }
}
