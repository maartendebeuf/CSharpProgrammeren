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
            Console.WriteLine("Geef een geheel getal in: ");
            int getal = int.Parse(Console.ReadLine());
            Console.WriteLine("Je gaf het getal " + getal + " in ;)");
            Console.ReadKey();
        }
    }
}
