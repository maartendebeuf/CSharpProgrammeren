using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2b
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 2

            //Maak een programma die op basis van de maand die je invoert het juiste seizoen weergeeft. Maak gebruik van beide voorwaardelijke statements(`if/else` en `switch`). 
            //Welke vind je het meest leesbaar?

            //*Lente: maart tot mei
            //* Zomer: juni tot augustus
            //* Herfst: september tot november
            //* Winter: december tot februari

            Console.WriteLine("Geef een maand in.");
            string maand = Console.ReadLine();

            switch (maand)
            {
                case "maart":
                    Console.WriteLine("seizoen = Lente");                   
                    break;
                case "april":
                    Console.WriteLine("seizoen = Lente");
                    break;
                case "mei":
                    Console.WriteLine("seizoen = Lente");
                    break;
                case "juni":
                    Console.WriteLine("seizoen = Zomer");
                    break;
                case "juli":
                    Console.WriteLine("seizoen = Zomer");
                    break;
                case "augustus":
                    Console.WriteLine("seizoen = Zomer");
                    break;
                case "september":
                    Console.WriteLine("seizoen = Herfst");
                    break;
                case "oktoer":
                    Console.WriteLine("seizoen = Herfst");
                    break;
                case "november":
                    Console.WriteLine("seizoen = Herfst");
                    break;
                case "december":
                    Console.WriteLine("seizoen = Winter");
                    break;
                case "januari":
                    Console.WriteLine("seizoen = Winter");
                    break;
                case "februari":
                    Console.WriteLine("seizoen = Winter");
                    break;
                default:
                    Console.WriteLine("je gaf geen maand in!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
