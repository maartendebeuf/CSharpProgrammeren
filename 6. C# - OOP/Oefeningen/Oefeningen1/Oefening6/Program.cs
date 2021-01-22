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
            //## Oefening 6 (Console)

            //Neem **de oplossing van oefening 7** uit de module *Arrays en collecties* en pas deze aan zodat je gebruik maakt van methodes.

            int aantal = 5;
            int[] getallen = new int[aantal];

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine("geef getal" + (i + 1) + " in: ");
                getallen[i] = int.Parse(Console.ReadLine());                
            }

            int gemiddeldePositief = GemiddeldePositief(getallen);
            int gemiddeldeNegatief = GemiddeldeNegatief(getallen);

            Console.WriteLine("Het gemiddelde van alle positieve getallen is: " + gemiddeldePositief);
            Console.WriteLine("Het gemiddelde van alle positieve getallen is: " + gemiddeldeNegatief);
            Console.ReadLine();
        }

        static int GemiddeldePositief(int[] inpGetallen)
        {
            int somPositief = 0;
            int aantPositief = 0;
            foreach (var getal in inpGetallen)
            {
                if (getal >= 0)
                {
                    somPositief += getal;
                    aantPositief++;
                }
            }
            int GemiddeldePositief = somPositief / aantPositief;
            return GemiddeldePositief;
        }

        static int GemiddeldeNegatief(int[] inpGetallen)
        {
            int somNegatief = 0;
            int aantNegatief = 0;
            foreach (var getal in inpGetallen)
            {
                if (getal < 0)
                {
                    somNegatief += getal;
                    aantNegatief++;
                }
            }
            int GemiddeldeNegatief = somNegatief / aantNegatief;
            return GemiddeldeNegatief;
        }        
    }
}
