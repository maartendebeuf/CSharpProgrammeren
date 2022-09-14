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
            double[] prijzen = new double[5];
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine("Geef prijs " + i + ":");
                var input = Console.ReadLine();
                prijzen[i] = double.Parse(input);

            }

        }
    }
}
