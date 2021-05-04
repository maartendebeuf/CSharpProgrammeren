# Oefeningen Generics

## Oefening 1

Voorzie een generieke klasse `Box` die een variabele van eender welk type verwacht en bewaart. Overschrijf de `ToString()` methode zodat die het exacte type en de waarde retourneert als **type class full name: value**.

**TIP:** om de volledige klassenaam van een type op te vragen, maak je gebruik van `[variabele].GetType().FullName`.

### Voorbeeld

Input: 123\
Output: System.Int32: 123

Input: "Test123"\
Output: System.String: Test123

## Oefening 2

//Voorzie een applicatie die vraagt hoeveel elementen een lijst bevat en vraag dit aantal waardes (van hetzelfde type) aan de gebruiker. 
//Nadat alle elementen gevraagd zijn, geeft de gebruiker twee indexes in.\
//Maak een generieke methode die een lijst van een specifiek, niet vooraf gedefinieerd type verwacht en twee indexes. 
//Gebruik deze indexes om de overeenkomende elementen te wisselen van plaats. Print daarna de lijst uit.

Voorzie een oplossing voor een lijst van `string` en een lijst van `int`.

### Voorbeelden

Input (aantal): 3\
Input (string waardes): Tom Tim Tam\
Input (indexes): 0 2\
Output: Tam Tim Tom

Input (aantal): 4\
Input (int waardes): 3 6 5 8\
Input (indexes): 3 1\
Output: 3 8 5 6

## Oefening 3
/*
//Maak een eigen implementatie van een generieke lijst. Implementeer onderstaande methodes:
//* `void Add(T element)`\
//Voeg het element toe aan het einde van de lijst
//* `T Remove(int index)`\
//Verwijder het element dat zich op de index bevindt uit de lijst
//* `bool Contains(T element)`\
//Controleer of het element zich in de lijst bevindt (true/false)
//* `T Max()`\
//Retourneer het laatste element
//* `T Min()`\
//Retourneer het eerste element
*/
Controleer zeker alle input!

Test je oplossing.