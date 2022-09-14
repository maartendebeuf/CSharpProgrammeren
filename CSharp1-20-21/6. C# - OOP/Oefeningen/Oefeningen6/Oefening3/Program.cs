using System;
using System.Collections.Generic;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de telefoonnummers gescheiden door spaties in:");
            string telefoonnummers = Console.ReadLine();
            Console.WriteLine("Geef de Url's gescheiden door spaties in:");
            string urls = Console.ReadLine();

            var telefoonnummer = telefoonnummers.Split(" ");
            var url = urls.Split(" ");

            Smartphone smartphone = new Smartphone();
            foreach (var item in telefoonnummer)
            {
                smartphone.Bellen(item);
            }
            foreach (var item in url)
            {
                smartphone.Surfen(item);
            }
            Console.ReadKey();
        }
    }
}
