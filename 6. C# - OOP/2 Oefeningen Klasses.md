## Oefeningen klassen

## Oefening 1

Ontwerp een applicatie om een bestelling te verwerken.\
Te bewaren in een object:
* Naam besteld artikel
* Eenheidsprijs artikel
* Aantal bestelde artikelen
* Totaalprijs bestelling

Werk met methodes en/of properties. Toon als laatste een overzicht van de bestelling (product, aantal, eenheidsprijs en totaalprijs).

**Uitbreiding**: Voorzie dat je een lijst met bestellingen kan toevoegen, opslaan en weergeven.

## Oefening 2

Ontwerp een applicatie voor de opslag van de gegevens van leerlingen. Sla de voornaam, de naam en de klas op. Geef de klasse een constructor waaraan je de voornaam, naam en klas kan meegeven als parameter. Zorg ervoor dat alle gegevens nog aangepast kunnen worden.

## Oefening 3

Quiz123 houdt de gegevens bij van de aangesloten quiz-teams. Ieder team bestaat uit 4 leden. Elk lid heeft een bepaalde specialiteit, bijvoorbeeld sport, film en muziek,…\
 Maak een klasse Lid. Geef de klasse een constructor waarmee je de naam van het lid en zijn/haar specialiteit kan invoeren. Geef de klasse ook een methode Print( ) die de properties van het betreffende lid op het scherm weergeeft.\
Maak een klasse Team die 4 instanties van Lid maakt. Geef de klasse een methode PrintAlleLeden()  die de namen van de leden en hun specialiteiten op het scherm toont.\
Voorzie twee constructors, één waar de leden in de constructor aangemaakt worden en één waar je een lijst van leden aan kan meegeven.

## Extra

Schrijf een robotsimulator.

De testfaciliteit van een robotfabriek heeft een programma nodig om robotbewegingen te controleren.

De robots hebben drie mogelijke bewegingen:
* Rechtsaf (R)
* Linksaf (L)
* Vooruit (V)

Robots worden op een hypothetisch oneindig raster geplaatst, met de voorkant naar een bepaalde richting (noord, oost, zuid of west) op een set van {x,y} coördinaten, bijvoorbeeld {3,8}, met coördinaten die naar het noorden en oosten toenemen.

De robot krijgt dan een aantal instructies, waarna de testfaciliteit de nieuwe positie van de robot verifieert en in welke richting hij wijst.

De string "RVVLVL" betekent:
1. Naar rechts
2. Twee keer vooruit
3. Naar links
4. Eén keer vooruit
5. Nogmaals links afslaan

Wanneer een robot begint op {7, 3} in noordelijke richting. Dan zouden bovenstaande instructies de robot laten eindigen op  {9, 4} westelijk.

**Bedenk, voor je begint, welke input nodig is bij start en alle daarop volgende stappen.**

**TIP**: Maak gebruik van een [enum](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum) voor de richting.