using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            Berekening berekening = new Berekening();
            int uitkomst = berekening.Fibonacci(5);
            Console.WriteLine(uitkomst);
            Console.ReadLine();
        }
    }
}
