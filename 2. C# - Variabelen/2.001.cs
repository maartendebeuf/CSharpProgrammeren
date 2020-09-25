// Schrijf een programma dat twee strings concateneert via beide manieren.

            Console.WriteLine("Geef een woord in: ");
            string woord1 = Console.ReadLine();
            Console.WriteLine("Geef een woord in: ");
            string woord2 = Console.ReadLine();
            Console.WriteLine("Concatenatie 1: " + woord1 + woord2);
            Console.WriteLine($"Concatenatie 2: {woord1}{woord2}");
            Console.WriteLine("Concatenatie 2: " + (woord1 += woord2));
            Console.ReadKey();