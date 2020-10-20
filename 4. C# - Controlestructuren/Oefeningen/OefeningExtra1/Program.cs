using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningExtra1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maak een applicatie waarmee je vijf maal onder elkaar de tekst toont “Programmeren in c# is leuk!”

            for( int i = 0; i<5; i++)
            {
                Console.WriteLine("Programmeren in c# is leuk!");
            }
            Console.ReadKey();
        }
    }
}
