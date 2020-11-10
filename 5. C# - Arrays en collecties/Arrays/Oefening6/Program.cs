using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 6
            //
            //Oefening 4 van de lijst met cijfers herwerken zodat er gebruik gemaakt wordt van een foreach loop.


            Console.WriteLine("Geef het aantal cijfers dat de lijst zal bevatten in: ");
            var aantal = int.Parse(Console.ReadLine());
            int[] cijfers = new int[aantal];
            int i = 1;
            foreach (int c in cijfers)
            {
                Console.WriteLine("Geef nummer " + i + ":");
                cijfers[i] = int.Parse(Console.ReadLine());
                i++;
            }

            //for (int i = 0; i < cijfers.Length; i++)
            //{
            //    Console.WriteLine("Geef nummer " + (i + 1) + ":");
            //    cijfers[i] = int.Parse(Console.ReadLine());
            //}
            int cijfer = 0;

            do
            {
                Console.WriteLine("Geef een cijfers in om te kijken of de lijst deze bevat: ");
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                cijfer = int.Parse(input);

            } while (!cijfers.Contains<int>(cijfer));
            Console.WriteLine("Einde");

            Console.ReadLine();
        }
    }
}
