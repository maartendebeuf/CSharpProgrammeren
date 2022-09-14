# Oefeningen

## Arrays

### Oefening 1

Maak een applicatie die vijf prijzen vraagt en die bewaart in een array en de prijzen daarna weergeeft.

### Oefening 2

Maak een applicatie die vijf namen vraagt en de namen daarna in omgekeerde volgorde toont.

### Oefening 3

Maak een applicatie die de punten opvraagt van zes leerlingen (twee groepen van drie) en van iedere groep het gemiddelde toont. Maak gebruik van een tweedimensionele array!

### Oefening 4

Maak een applicatie die controleert of een lijst met cijfers een ingegeven cijfer bevat.  
Volgende stappen worden genomen:
1. Vraag hoeveel cijfers de lijst zal bevatten.
2. Maak een lijst aan van die grootte en vraag data aan de gebruiker om de lijst te vullen.
3. Na het vullen van de lijst: vraag de gebruiker naar een cijfer.
4. Controleer of dit nummer in de lijst te vinden is en laat het resultaat weten aan de gebruiker.
5. De gebruiker kan de applicatie afsluiten door het woord 'stop' te typen of verder te zoeken door op enter te klikken.

### Oefening 5

Maak een applicatie die een aantal getallen vraagt. Toon enkel de oneven getallen. Maak gebruik van een foreach!

### Oefening 6

Oefening 4 van de lijst met cijfers herwerken zodat er gebruik gemaakt wordt van een foreach loop.

### Oefening 7

Maak een applicatie die 10 getallen vraagt en daarna het gemiddelde van alle positieve en het gemiddelde van alle negatieve getallen berekent en toont.

## Collections

### Oefening 1

Vraag vijf namen aan de gebruiker, voeg deze toe in een lijst en toon alle namen. Vraag daarna aan de gebruiker welke naam verwijdert moet worden en toon de aangepaste lijst.

### Oefening 2

Vul een lijst met tien willekeurige getallen, sorteer de lijst van klein naar groot en toon de gesorteerde lijst op het scherm.\
Hieronder vindt je voorbeeldcode een willekeurig getal te genereren.

``` C#
// Willekeurige getallen
var randomizer = new Random();
// Genereer twee random getallen tussen 1 en 100;
var getal1 = randomizer.Next(1, 100);
var getal2 = randomizer.Next(1, 100);
```

### Oefening 3

Vraag een nummer X en vul daarmee een Dictionary<T> waarvan de key X is en de waarde X*X is, waarbij X start bij 1. Toon daarna alle paren (key/value).\
Vb: X = 4 -> {1,1} {2,4} {3,9} {4,16}

### Oefening 4

Maak gebruik van een collectie die bijhoudt hoeveel keer een letter voorkomt in een zin. Toon de uitkomst op het scherm.\
Vb: "abbc" -> a: 1, b: 2, c: 1

### Oefening 5

Maak een programma met een grote multiLine `TextBox`. Je kan hier een willekeurige tekst invoeren.\
Plaats daarnaast een invoervak waarin de gebruiker maximaal **1 teken** mag invoeren.

1. Zorg voor een knop die weergeeft hoeveel keer het ingevoerde teken voorkomt in de ingevoerde tekst.
2. Zorg voor een knop die het aantal klinkers telt.
3. Zorg voor een knop die het aantal spaties telt.
4. Zorg voor een knop die het aantal medeklinkers telt.

Zorg voor een correcte foutafhandeling.

### Oefening 6

Maak een programma met een `ComboBox`, `TextBox` en twee `Buttons`. Het programma heeft volgende eigenschappen:
* De `ComboBox` heeft een hoogte van *30 pixels* en een breedte van *200 pixels*. 
* De `ComboBox` bevat een lijst met dranken.
* Het tweede element in de `ComboBox` is standaard geselecteerd.
* De eerste `Button` voegt de tekst uit de `TextBox` toe aan de lijst.
* De tweede `Button` verwijdert het **geselecteerde** element.

### Oefening 7

Pas oefening 6 aan met een extra `ComboBox`, twee `Buttons` een `TextBox` en een `TextBlock` met volgende eigenschappen:
* De `ComboBox` bevat een lijst met ingrediënten.
* De eerste `Button` voegt de tekst uit de `TextBox` toe aan de lijst met ingrediënten.
* De tweede `Button` koppelt **één of meerdere** geselecteerde ingrediënten aan een geselecteerde drank. (Tip: controleer de selectie!)
* Bewaar de koppeling drank <> ingrediënt in een `Dictionary`. Denk goed na wat het *keytype* en *valuetype* is van de `Dictionary<K,T>`.
* Toon de dranken en hun ingrediënt(en) in het `TextBlock` (tip: een nieuwe lijn starten in een `string` kan met `\n`).

Zorg voor een correcte foutafhandeling
