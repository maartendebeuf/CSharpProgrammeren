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
            //### Oefening 3

            //Ontwerp een applicatie waarmee je aan de gebruiker het resultaat van 5 examens opvraagt. 
            //De opgevraagde resultaten zijn de behaalde punten op 100.
            //De student is geslaagd als hij hoogstens 1 onvoldoende heeft en een gemiddelde van minstens 50 % behaalde.

            Console.WriteLine("Geef je laatste examenresultaten in (op 100)");
            int maxExamens = 5;
            int geslaagd = 0;
            double gemiddelde = 0;
            for(int i = 0; i < maxExamens; i++)
            {
                Console.WriteLine((i+1) + "/5:");
                double examen = double.Parse(Console.ReadLine());
                if (examen > 50)
                {
                    geslaagd++;
                }
                gemiddelde += examen / maxExamens;
            }

            if (geslaagd>= maxExamens - 1
                && gemiddelde>50)
            {
                Console.WriteLine("Je bent geslaagd! " + (maxExamens- geslaagd) + " onvoldoendes en " + gemiddelde + "%. :)");
            }
            else if (geslaagd < maxExamens - 1
                && gemiddelde > 50)
            {
                Console.WriteLine("Je bent niet geslaagd! Je had " + (maxExamens - geslaagd) + " onvoldoendes. :(");
            }
            else if (geslaagd >= maxExamens - 1
                && gemiddelde < 50)
            {
                Console.WriteLine("Je bent niet geslaagd! Je behaalde maar " + gemiddelde + "% :(");
            }
            else
            {
                Console.WriteLine("Je bent niet geslaagd! Je had " + (maxExamens - geslaagd) + " onvoldoendes en behaalde maar " + gemiddelde + "% :(");
            }

            Console.ReadKey();

        }
    }
}
