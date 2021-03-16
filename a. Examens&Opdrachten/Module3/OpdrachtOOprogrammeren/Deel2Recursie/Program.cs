using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel2Recursie
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursie recursie = new Recursie();
            int resultaat = recursie.NatuurlijkGetal(23455);
            Console.WriteLine("Waarde: " + resultaat);
            Console.ReadKey();
        }
    }
}
