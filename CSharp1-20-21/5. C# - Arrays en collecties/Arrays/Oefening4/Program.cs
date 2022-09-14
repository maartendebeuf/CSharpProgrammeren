using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 4
            //
            //Maak een applicatie die controleert of een lijst met cijfers een ingegeven cijfer bevat.  
            //Volgende stappen worden genomen:
            //1. Vraag hoeveel cijfers de lijst zal bevatten.
            //2. Maak een lijst aan van die grootte en vraag data aan de gebruiker om de lijst te vullen.
            //3. Na het vullen van de lijst: vraag de gebruiker naar een cijfer.
            //4. Controleer of dit nummer in de lijst te vinden is en laat het resultaat weten aan de gebruiker.
            //5. De gebruiker kan de applicatie afsluiten door het woord 'stop' te typen of verder te zoeken door op enter te klikken.

            Console.WriteLine("Geef het aantal cijfers dat de lijst zal bevatten in: ");
            var aantal = int.Parse(Console.ReadLine());
            int[] cijfers = new int[aantal];

            for (int i = 0; i < cijfers.Length; i++)
            {
                Console.WriteLine("Geef nummer " + (i+1) + ":");
                cijfers[i] = int.Parse(Console.ReadLine());
            }
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
