using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening 7
            //
            //Maak een applicatie die 10 getallen vraagt en daarna het gemiddelde van alle positieve en het gemiddelde van alle negatieve getallen berekent en toont.

            int aantal = 10;
            int[] getallen = new int[aantal];
            int somNegatief = 0;
            int aantNegatief = 0;
            int gemNegatief = 0;
            int somPositief = 0;
            int aantPositief = 0;
            int gemPositief = 0;

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine("geef getal" + (i + 1) + " in: ");
                getallen[i] = int.Parse(Console.ReadLine());

                if (getallen[i] % 2.0 != 0)
                {                    
                    somNegatief += getallen[i];
                    aantNegatief++;
                }
                else 
                {
                    somPositief += getallen[i];
                    aantPositief++;
                }
            }
            Console.WriteLine("Het gemiddelde van alle positieve getallen is: " + (somPositief/ aantPositief));
            Console.WriteLine("Het gemiddelde van alle positieve getallen is: " + (somNegatief / aantNegatief));
            Console.ReadLine();

        }
    }
}
