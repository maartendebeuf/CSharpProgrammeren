# OOP
## Methodes

## Recursie

* Een methode die zichzelf aanroept
* Belangrijk! De methode moet een voorwaarde bevatten die de uitvoering stopt. Zo niet, dan blijft de methode oneindig lopen.

## Classes

### Intro

* Klasse vs. Object
    - Klasse: uitwerking van een type
    - Object: instantie van een bepaalde klasse

* Wordt gemaakt om:
    - Een object te beschrijven. Vb: hond, telefoon, rekenmachine, …
    - Vlakke datastructuur weer te geven. Vb: integer, string, …
    - Interactie tussen verschillende klassen te regelen

### Properties

Auto-implemented property

*"prop"*
```csharp
public int MyProperty { get; set; }
```

*"propfull"*
```csharp
private int myVar;

public int MyProperty
{
    get { return myVar; }
    set { myVar = value; }
}
```
Alleen-lezen variabelen en properties
```csharp
private readonly int myVar;
```
