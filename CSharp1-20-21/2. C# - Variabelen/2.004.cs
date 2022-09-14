// Schrijf een programma dat de lengte van een `string` toont in de console.

            Console.WriteLine("Geef een woord in: ");
            string woord = Console.ReadLine();
            int count = woord.Count();
            Console.WriteLine("Het ingegeven woord is " + count + " letters lang");
            Console.ReadKey();