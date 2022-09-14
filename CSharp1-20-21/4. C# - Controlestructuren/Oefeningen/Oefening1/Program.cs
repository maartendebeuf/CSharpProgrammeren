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
            //### Oefening 1

            //Vraag een leeftijd en afhankelijk van de waarde, toon onderstaande boodschap:
            //*Jonger dan 18: "U bent nog niet volwassen."
            //* Tussen 18 en 25: "U bent een jongvolwassene."
            //* Ouder dan 25: "U bent volwassen."
            bool geldigGetal = true;
            do
            {                
                try
                {
                    Console.WriteLine("Geef uw leeftijd in.");
                    int leeftijd = int.Parse(Console.ReadLine());

                    if (leeftijd < 18)
                    {
                        Console.WriteLine("U bent nog niet volwassen.");
                    }
                    else if (leeftijd <= 25)
                    {
                        Console.WriteLine("U bent een jongvolwassene.");
                    }
                    else
                    {
                        Console.WriteLine("U bent volwassen.");
                    }
                    Console.ReadKey();
                }                
                catch (FormatException)
                {
                    Console.WriteLine("Je gaf een verkeerd teken in.\nprobeer nog eens.\n---");
                    geldigGetal = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("Je gaf geen geldig getal in.\nprobeer nog eens.\n---");
                    geldigGetal = false;

                }

            } while (!geldigGetal);
            

        }
    }
}
