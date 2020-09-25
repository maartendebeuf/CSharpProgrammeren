// Schrijf een programma dat de lengte van een `string` toont in de console.

            Console.WriteLine("Geef een woord in: ");
            string woord = Console.ReadLine();
            int count = woord.Count();
            Console.WriteLine("de lengte van het ingegeven woord is: " + count);
            Console.ReadKey();