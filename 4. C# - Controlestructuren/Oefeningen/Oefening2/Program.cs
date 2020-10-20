using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
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

            if (maand.ToLower()== "maart" 
                || maand.ToLower() == "april"
                || maand.ToLower() == "mei")
            {
                Console.WriteLine("seizoen = Lente");
                Console.ReadKey();
            }
            else if (maand.ToLower() == "juni"
                || maand.ToLower() == "juli"
                || maand.ToLower() == "augustus")            
            {
                Console.WriteLine("seizoen = Zomer");
                Console.ReadKey();
            }
            else if (maand.ToLower() == "september"
                || maand.ToLower() == "oktoer"
                || maand.ToLower() == "november")
            {
                Console.WriteLine("seizoen = Herfst");
                Console.ReadKey();
            }
            else if (maand.ToLower() == "december"
                || maand.ToLower() == "januari"
                || maand.ToLower() == "februari")
            {
                Console.WriteLine("seizoen = Winter");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("je gaf geen maand in!");
                Console.ReadKey();
            }
        }
    }
}
