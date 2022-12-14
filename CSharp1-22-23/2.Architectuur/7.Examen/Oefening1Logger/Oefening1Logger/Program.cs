// See https://aka.ms/new-console-template for more information
using Oefening1Logger;

Console.WriteLine("Hello, World!");
//Een loggerklasse dient gemaakt te worden om een bericht weg te schrijven naar een logbestand.
//Zorg ervoor dat er maar 1 connectie naar het logbestand gemaakt wordt vanuit de applicatie.

//De loglijnen dienen eruit te zien als volgt:

//2022-12-07  18:30:00    Het bericht die gelogd dient te worden
Logger.GetInstance.Log("Het bericht die gelogd dient te worden");