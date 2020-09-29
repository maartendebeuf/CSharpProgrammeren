// Schrijf een programma dat een datum of datum/tijd vraagt aan de gebruiker en dit omzet naar een `DateTime`
            Console.WriteLine("Geef een datum in: (xx/xx/xxxx)");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("De ingegeven datum is: " + datum.ToShortDateString());
            
            Console.ReadKey();