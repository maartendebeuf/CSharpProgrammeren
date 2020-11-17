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
            //Maak gebruik van een collectie die bijhoudt hoeveel keer een letter voorkomt in een zin. 
            //Toon de uitkomst op het scherm.\
            //Vb: "abbc"->a: 1, b: 2, c: 1
            Console.WriteLine("Geef een zin in.");
            string zin = Console.ReadLine();

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (char letter in zin)
            {
                if (!keyValuePairs.ContainsKey(letter))
                {
                    keyValuePairs.Add(letter, 1);
                }
                else
                {
                    int aantal = keyValuePairs[letter];
                    keyValuePairs[letter] = aantal+1;
                }
                Console.WriteLine(letter);
            }
            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine(keyValue.Key + ", " + keyValue.Value);
            }
            Console.ReadLine();
        }
    }
}
