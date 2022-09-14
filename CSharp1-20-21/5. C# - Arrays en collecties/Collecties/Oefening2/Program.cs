using NUnit.Framework.Internal;
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

            //Vul een lijst met tien willekeurige getallen, sorteer de lijst van klein naar groot en toon de gesorteerde lijst op het scherm.\
            //Hieronder vindt je voorbeeldcode een willekeurig getal te genereren.

            //``` C#
            // Willekeurige getallen
            //var randomizer = new Random();
            // Genereer twee random getallen tussen 1 en 100;
            //var getal1 = randomizer.Next(1, 100);
            //var getal2 = randomizer.Next(1, 100);

            var nummers = new List<int>();            
            var randomizer = new Random();
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            nummers.Add(randomizer.Next(1, 100));
            for (int i = 0; i < nummers.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + nummers[i]);
            }
            Console.WriteLine("\nDruk op enter om te sorteren.");
            Console.ReadLine();
            nummers.Sort();
            for(int i = 0; i < nummers.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + nummers[i]);
            }
            Console.ReadLine();
        }
    }
}
