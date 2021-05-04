using System;
using System.Collections.Generic;

namespace Oefening2
{
    class Program
    {
        //Voorzie een applicatie die vraagt hoeveel elementen een lijst bevat en vraag dit aantal waardes (van hetzelfde type) aan de gebruiker. 
        //Nadat alle elementen gevraagd zijn, geeft de gebruiker twee indexes in.\
        //Maak een generieke methode die een lijst van een specifiek, niet vooraf gedefinieerd type verwacht en twee indexes. 
        //Gebruik deze indexes om de overeenkomende elementen te wisselen van plaats. Print daarna de lijst uit.
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel elementen zal de lijst bevatten?");
            int aantal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Geef de waardes in gescheden door een spatie:");
            string waardes = Console.ReadLine();
            string[] waardeLijst = waardes.Split(" ");
            List<string> waardeLijst2 = new List<string>(waardeLijst);

            Console.WriteLine($"Geef twee indexes in gescheden door een spatie:");
            string indexes = Console.ReadLine();
            var indexLijst = indexes.Split(" ");
            App app = new App();
            var outLijst = app.Input(waardeLijst2, int.Parse(indexLijst[0]), int.Parse(indexLijst[1]));
        }
    }
}
