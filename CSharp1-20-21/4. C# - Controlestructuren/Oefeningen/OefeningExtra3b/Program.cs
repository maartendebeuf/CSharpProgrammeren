using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningExtra3b
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 3b

            //Uitbreiding voorgaande oefening:
            //Vraag ook vanaf welk getal de tafel moeten worden getoond en hoeveel berekeningen er moeten worden getoond
            Console.Write("Geef een nummer in: ");
            int getal = int.Parse(Console.ReadLine());
            Console.Write("Vanaf welk getal moet er begonnen worden: ");
            int startGetal = int.Parse(Console.ReadLine());
            Console.Write("Hoeveel keer: ");
            int aantal = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                if (getal * i < startGetal)
                {
                    i++;
                    aantal++;
                }
                else
                {
                    Console.WriteLine(getal * i);
                    i++;
                }
            } while (i!=aantal);
            
            Console.ReadKey();
        }
    }
}
