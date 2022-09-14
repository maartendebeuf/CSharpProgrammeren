using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningExtra2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maak een applicatie waarmee je vijf verschillende gehele getallen kan invoeren.De applicatie toont daarna het grootste getal van alle ingevoerde getallen.
            int grootsteGetal = 0;
            int aantalGetallen = 5;

            Console.WriteLine("geef " + aantalGetallen + "verschillende gehele getallen in.");
            for (int i = 0; i<aantalGetallen; i++)
            {
                Console.WriteLine((i + 1) + "/5:");
                int getal = int.Parse(Console.ReadLine());
                if (grootsteGetal< getal)
                {
                    grootsteGetal = getal;
                }
            }
            Console.WriteLine("Het grootste getal van alle ingevoerde getallen is " + grootsteGetal);
            Console.ReadKey();
        }
    }
}
