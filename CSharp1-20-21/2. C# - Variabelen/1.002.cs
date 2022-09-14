//Vraag drie gehele getallen aan de gebruiker en toon de som in de console

Console.WriteLine("Geef een geheel getal 1 in: ");
int getal1 = int.Parse(Console.ReadLine());
Console.WriteLine("Geef een geheel getal 2 in: ");
int getal2 = int.Parse(Console.ReadLine());
Console.WriteLine("Geef een geheel getal 3 in: ");
int getal3 = int.Parse(Console.ReadLine());
Console.WriteLine("De som van de ingegeven getallen is: " + (getal1+getal2+getal3));
Console.ReadKey();