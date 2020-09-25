// Schrijf een programma dat alle spaties **voor** een woord/zin verwijdert.

            Console.WriteLine("Geef enkele spaties en een woord in: ");
            string woord1 = Console.ReadLine();            
            Console.WriteLine("Woord zonder spaties: " + woord1.TrimStart());            
            Console.ReadKey();