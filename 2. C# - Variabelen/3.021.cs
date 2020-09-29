// Schrijf een programma dat twee strings vergelijkt.

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