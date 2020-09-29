// Schrijf een programma dat een `DateTime` omzet naar het formaat *01 januari 2019, 12:00*.
                        
            DateTime datum = DateTime.Now;

            Console.WriteLine("De ingegeven datum is: " + datum.ToString("dd MMMM yyyy, HH:mm"));
            
            Console.ReadKey();