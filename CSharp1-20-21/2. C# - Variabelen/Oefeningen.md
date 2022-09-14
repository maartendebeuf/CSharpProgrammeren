# Oefeningen

## Getallen (byte, int, double, decimal, float, ...)

### Console

1. Vraag een geheel getal aan de gebruiker
2. Vraag drie gehele getallen aan de gebruiker en toon de som in de console
3. Vraag een kommagetal een plaats dit in een variabele.
4. Vraag een kommagetal aan en converteer dit naar een geheel getal

### WPF

1. Boek pagina 32 - Invoer getallen

## Tekst (char, string)

Alle waardes worden gevraagd aan de gebruiker via `Console.ReadLine()`.
1. Schrijf een programma dat twee strings concateneert via beide manieren.
2. Schrijf een programma dat een `string` naar een andere `string` kopieert. Wat merk je op als je de waarde van een variabele aanpast?
4. Schrijf een programma dat de lengte van een `string` toont in de console.
5. Schrijf een programma dat een tekst naar enkel hoofdletters omzet.
6. Schrijf een programma dat een tekst naar enkel kleine letters omzet.
7. Schrijf een programma dat alle spaties **voor** een woord/zin verwijdert.
8. Schrijf een programma dat alle spaties **voor of na** een woord/zin verwijdert.
9. Schrijf een programma dat een bepaald getal/karakter vervangt door een andere waarde.

## Booleaans (true, false)

Wat is het resultaat van volgende beweringen?

1. `true && true` //true 
2. `false && true` // false
3. `1 == 1 && 2 == 1` //false
4. `"test" == "test"` //true
5. `1 == 1 || 2 != 1` //true
6. `true && 1 == 1` //true
7. `false && 0 != 0` //false
8. `true || 1 == 1` //true
9. `"test" == "testing"`//false
10. `1 != 0 && 2 == 1` //false
11. `"test" != "testing"` //true
12. `"test" == 1` //foutmelding == cannot be applied to operands of type 'string' and 'int'
13. `!(true && false)` //true
14. `!(1 == 1 && 0 != 1)` //false
15. `!(10 == 1 || 1000 == 1000)` //false
16. `!(1 != 10 || 3 == 4)` //false
17. `!("testing" == "testing" && "A" == "B")` //true
18. `1 == 1 && !("testing" == 1 || 1 == 0)` //foutmelding == cannot be applied to operands of type 'string' and 'int'
19. `"meat" == "bacon" && !(3 == 4 || 3 == 3)` //false
20. `3 == 3 && !("testing" == "testing" || "C#" == "Fun")` //false


21. Schrijf een programma dat twee strings vergelijkt.

## Datum en tijd (DateTime)

### Console

1. Schrijf een programma dat de huidige tijd weergeeft in de console.
2. Schrijf een programma dat de seconden van de huidige tijd weergeeft in de console.
3. Schrijf een programma dat een datum of datum/tijd vraagt aan de gebruiker en dit omzet naar een `DateTime`.
4. Schrijf een programma dat een `DateTime` omzet naar het formaat *01 januari 2019, 12:00*.

### WPF

1. Boek pagina 28 - Voorbeeld
2. Schrijf een programma dat een `DateTime` vraagt aan de gebruiker en daarbij X dagen bijtelt. Toon het resultaat aan de gebruiker.

## Combinaties

Maak voor iedere oefening een nieuw project aan en push het naar GitHub. Antwoorden op vragen mogen als commentaar in de oplossing geplaatst worden.  
**Schrijf commentaar waar nodig.**

1. Vraag een naam en toon die daarna aan de gebruiker.
2. Vraag een naam en geef dan een bericht terug waarin de naam verwerkt is.
3. Schrijf een consoleapplicatie die gebruik maakt van twee variabelen (firstname, lastname) die reeds geïnitializeerd zijn en toon de waardes als één lijn op het scherm. Pas daarna via input van de gebruiker beide variabelen aan en toon de volledige naam op het scherm.
4. Schrijf een consoleapplicatie die de som van twee ingegeven getallen berekent en de uitkomst toont op het scherm. Wat gebeurt er als je een letter ingeeft? Hoe vangen we dit op? Pas dit ook toe op je oplossing.
5. Schrijf een consoleapplicatie die twee getallen vraagt en controleert of één van de twee getallen tussen -20 en 125 ligt en print de uitkomst op het scherm.
6. Schrijf een consoleapplicatie die 'true' retourneert als het een even getal is en 'false' als het een oneven getal is.
7. Bereken hoe lang iemand reeds leeft in gigaseconden (=1.000.000.000s)
8. Is een jaar een schrikkeljaar of niet?
   Een schrikkeljaar is:    
    * Restloos deelbaar door 4, maar niet door 100
    * Of restloos deelbaar door 400
    
    Voorbeeld: 1997 is geen schrikkeljaar, 1996 wel. 1900 niet, maar 2000 wel.
