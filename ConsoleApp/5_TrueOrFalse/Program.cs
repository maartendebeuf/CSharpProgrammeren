using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schrijf een consoleapplicatie die 'true' retourneert als het een even getal is en 'false' als het een oneven getal is.

            Console.WriteLine("geef een getal in: ");
            int getal = int.Parse(Console.ReadLine());
            bool evenOfOneven = false;
            if (getal%2 == 0)
            {
                evenOfOneven = true;
            }
            Console.WriteLine("Even: " + evenOfOneven.ToString());
            Console.ReadLine();

        }
    }
}
