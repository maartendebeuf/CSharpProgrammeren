using System;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            //### Oefening 3
            //Maak een applicatie die de punten opvraagt van zes leerlingen (twee groepen van drie) en van iedere groep het gemiddelde toont. Maak gebruik van een tweedimensionele array!

            int groepen = 2;
            int leerlingen = 3;
            double[,] punten = new double[groepen, leerlingen];            
            for (int i = 0; i < groepen; i++)
            {
                for (int j = 0; j < leerlingen; j++)
                {
                    Console.WriteLine("Geef de punten van leerling " + (j+1) + " uit groep " + (i + 1) + " :");
                    var input = Console.ReadLine();
                    punten[i,j] = double.Parse(input);                    
                }                
            }
            for (int i = 0; i < groepen; i++)
            {
                double gemiddelde = 0;
                for (int j = 0; j < leerlingen; j++)
                {
                    gemiddelde = gemiddelde + (punten[i, j] / leerlingen);

                }
                Console.WriteLine("Het gemiddelde van groep " + (i + 1) + " is: " + gemiddelde);
            }
            Console.ReadLine();
        }
    }
}
