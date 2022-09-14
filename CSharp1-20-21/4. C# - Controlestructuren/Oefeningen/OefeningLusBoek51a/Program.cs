using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningLusBoek51a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geef een nummer van 1 tot 100 in: ");
            int getal = int.Parse(Console.ReadLine());
            Console.Write("Geef een nummer van 1 tot 10 in: ");
            int aantal = int.Parse(Console.ReadLine());
            for (int i = 1; i < aantal; i++)
            {
                int j = 0;
                Console.Write(getal);
                while (j<i)
                {
                    Console.Write(" x " + getal);
                    j++;
                }
                Console.Write(" = " + (Math.Pow(getal,i+1) + "\n"));

            }
            Console.ReadKey();
        }
    }
}
