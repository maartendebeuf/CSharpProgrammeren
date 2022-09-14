// Vraag een kommagetal aan en converteer dit naar een geheel getal

            Console.WriteLine("Geef een kommagetal in: ");
            double kommagetal = double.Parse(Console.ReadLine());
            int geheelGetal = (int)kommagetal;
            Console.WriteLine("Je gaf het getal " + geheelGetal + " in.");
            Console.ReadKey();