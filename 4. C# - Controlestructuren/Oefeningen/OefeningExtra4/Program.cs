using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningExtra4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ontwerp een applicatie die de gebruiker om een getal vraagt. Het programma laat dan de rij van Fibonacci van zoveel getallen zien.  
            //De rij van Fibonacci is een rij getallen waarbij je bij 0 en 1 begint.Vervolgens is elk getal in de rij de optelling van de twee voorgaande getallen.Dus:
            //*0 + 1 = 1
            //* 1 + 1 = 2
            //* 1 + 2 = 3
            //* 2 + 3 = 5
            //* 3 + 5 = 8
            //* …  

            //De rij van Fibonacci is dus: 0, 1, 1, 2, 3, 5 , 8, ...

            Console.Write("Geef een nummer van 1 tot 100 in: ");
            int aantal = int.Parse(Console.ReadLine());

            int getal1 = 0;
            int getal2 = 1;
            for (int i = 0; i < aantal; i++)
            {
                int uitkomst = getal1 + getal2;
                Console.WriteLine(getal1 + " + " + getal2 + " = " + uitkomst);
                getal1 = getal2;
                getal2 = uitkomst;
            }
            Console.ReadKey();
        }
    }
}
