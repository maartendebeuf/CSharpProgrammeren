using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vraag vijf namen aan de gebruiker, voeg deze toe in een lijst en toon alle namen. 
            //Vraag daarna aan de gebruiker welke naam verwijdert moet worden en toon de aangepaste lijst.

            int aantalNamen = 5;
            var namen = new List<string>();
            Console.WriteLine($"Geef {aantalNamen} namen in.");
            for (int i = 0; i < aantalNamen; i++)
            {
                Console.Write($"Naam {(i+1)}:");
                namen.Add(Console.ReadLine());
            }                        
            for(int i = 0; i < namen.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + namen[i]);                
            }
            Console.ReadLine();
            Console.WriteLine("Welke naam mag er weg?");
            namen.RemoveAt((int.Parse(Console.ReadLine()))-1);
            for (int i = 0; i < namen.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + namen[i]);
            }
            Console.ReadLine();
        }
    }
}
