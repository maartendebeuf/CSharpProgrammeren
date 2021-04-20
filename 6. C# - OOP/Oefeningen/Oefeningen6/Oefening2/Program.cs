using System;
namespace Oefening2
{
    //Gebruik de code van de vorige oefening om een interface `IIdentifiable` te maken met een eigenschap string `Id` 
    //en een interface `IBirthable` met een eigenschap DateTime `Geboortedatum` en 
    //deze te implementeren in onze `Inwoner` klasse . Herschrijf de constructor met die nieuwe parameters.
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam = "Maarten";
            string naam = "De Beuf" ; 
            int leeftijd = 36 ;
            Guid id = new Guid();
            DateTime geboortedatum = new DateTime();            

            Inwoner inwoner = new Inwoner(voornaam, naam, leeftijd, id, geboortedatum);

            Console.WriteLine("Hello World!");
        }
    }
}
