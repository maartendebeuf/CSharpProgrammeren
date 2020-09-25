// Schrijf een programma dat een `string` naar een andere `string` kopieert. Wat merk je op als je de waarde van een variabele aanpast?

            Console.WriteLine("Geef een woord in: ");
            string woord1 =Console.ReadLine();            
            string woord2 = woord1;
            Console.WriteLine("Geen idee: " + woord1 + woord2);
            Console.ReadKey();