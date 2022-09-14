// Schrijf een programma dat een `DateTime` vraagt aan de gebruiker en daarbij X dagen bijtelt. Toon het resultaat aan de gebruiker.

            Console.WriteLine("Geef een datum in: (xx/xx/xxxx)");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("aantal dagen vooruit: ");
            int dagenVooruit = int.Parse(Console.ReadLine());

            Console.WriteLine("De uitgekomen datum is: " + (dateTime.AddDays(dagenVooruit)));
            
            Console.ReadKey();