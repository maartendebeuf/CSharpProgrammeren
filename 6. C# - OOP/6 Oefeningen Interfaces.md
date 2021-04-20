# Oefeningen Interfaces

## Oefening 1

Definieer een interface `IPerson` met eigenschappen voor Naam en Leeftijd. Definieer een klasse `Inwoner` die `IPerson` implementeert en een constructor heeft die een naam en een leeftijd verwacht.

## Oefening 2

Gebruik de code van de vorige oefening om een interface `IIdentifiable` te maken met een eigenschap string `Id` en een interface `IBirthable` met een eigenschap DateTime `Geboortedatum` en deze te implementeren in onze `Inwoner` klasse . Herschrijf de constructor met die nieuwe parameters.

## Oefening 3

Het is de bedoeling dat je simpele telefoonsoftware schrijft, maak hiervoor gebruik van interfaces. Momenteel bevat je project één klasse: `Smartphone`. Dit type heeft de volgende functionaliteit: bellen en surfen op het web.\
Voorzie één klasse en twee interfaces die bovenstaande functionaliteit implementeren.

### Input

Input via de console via twee inputlijnen:
* Telefoonnummers gescheiden door spaties
* Url's gescheiden door spaties

### Output

* Bel eerst alle nummers
* Surf daarna naar alle websites
  
**Bellen**\
Het bellen naar een nummer wordt als volgt weergegeven in de console: `Bellen... [nummer]`

**Surfen**\
Het surfen naar een website wordt als volgt weergegeven in de console: `Laden website... [url]`

### Tip

Het splitsen van een string op een bepaald character kan via een `string` methode.