using System;

namespace Oefening1
{//Definieer een interface `IPerson` met eigenschappen voor Naam en Leeftijd. Definieer een klasse `Inwoner` die `IPerson` implementeert en een constructor heeft die een naam en een leeftijd verwacht.

    class Program
    {
        static void Main(string[] args)
        {
            Inwoner inwoner = new Inwoner("Maarten", "De Beuf", 36);

            Console.WriteLine("Hello World!");
        }
    }
}
