﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat de huidige tijd weergeeft in de console.

            Console.WriteLine("Geef een woord in: ");
            string woord1 = Console.ReadLine();
            Console.WriteLine("Geef nog een woord in: ");
            string woord2 = Console.ReadLine();
            if (woord1.CompareTo(woord2) == 0)
            {
                Console.WriteLine("het eerste woord is gelijk aan het tweede.");
            }
            else if (woord1.CompareTo(woord2) == 1)
            {
                Console.WriteLine("het eerste woord is niet gelijk aan het tweede.");
            }      
            Console.ReadKey();
        }
    }
}
