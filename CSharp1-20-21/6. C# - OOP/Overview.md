# OOP
## Methodes

## Recursie

* Een methode die zichzelf aanroept
* Belangrijk! De methode moet een voorwaarde bevatten die de uitvoering stopt. Zo niet, dan blijft de methode oneindig lopen.

## Classes

### - Intro

* Klasse vs. Object
    - Klasse: uitwerking van een type
    - Object: instantie van een bepaalde klasse

* Wordt gemaakt om:
    - Een object te beschrijven. Vb: hond, telefoon, rekenmachine, …
    - Vlakke datastructuur weer te geven. Vb: integer, string, …
    - Interactie tussen verschillende klassen te regelen

#### Modifiers
* **Private:** Private kenmerken van de superklasse zijn alleen zichtbaar in subklassen die zijn genest in hun superklasse.
* **Protected:** Beschermde kenmerken van de superklasse zijn enkel zichtbaar in subklassen.
* **Internal:** Interne kenmerken van de superklasse zijn enkel zichtbaar in de subklasse als die zich in hetzelfde project bevindt als de superklasse.
* **Public:** Publiek kenmerken van de superklasse zijn zichtbaar in de subklasse en behoren tot de publieke interface van de subklasse alsof ze beschreven zijn in de subklasse zelf.

### - Properties

Auto-implemented property

* **_"prop"_**
```csharp
public int MyProperty { get; set; }
```

* **_"propfull"_**
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

### - Overerving

Het laat je toe om een subklasse (child class) te definiëren die de eigenschappen van de superklasse (base class) hergebruikt, uitbreidt of aanpast

```csharp
public Class BaseClass
{
}
public Class SubClass : BaseClass
{
    // : base() verwijst naar de constructor in de superklasse
    public SubClass(string Naam)
        : base(naam)
    {

    }
    // : this() verwijst naar de constructor in de eigenklasse
    public SubClass(string Naam, string type)
        : this(naam)
    {
        Type = type;
    }
    public string TypeAsString()        
    {
        //verwijst naar een methode in de superclass
        return base.Type();
    }

}
```

#### Klasseniveau
* Je kan maar van één klasse erven
* Binnen een subklasse kunnen eigen variabelen, properties, methodes, … beschreven worden die niet in de superklasse voorkomen
* De constructor van de superklasse wordt niet geërfd. Iedere klasse heeft nog steeds eigen constructors
* Erven (inherit): een klasse kan de variabelen, properties, methodes, … overnemen van een andere klasse. 
* This versus base
    * **_This:_** het huidige object waarop je werkt. De klasse waarin je bezig bent.
    * **_Base:_** het superklasse object van het huidige object

#### Methodeiveau
* Overschrijven van een methode of property van de superklasse 
* Een andere implementatie voorzien van een methode of property in de subklasse
* **Superklasse:** methode of property voorzien van het keyword **_virtual_**
    * Merkt de methode of property als overschrijfbaar
* **Subklasse:** methode of property voorzien van het keyword **_override_**
    * Laat de compiler weten dat het een nieuwe implementatie is van een bestaande methode of property

### - Abstract

* Abstracte **klasse**
    * Klasse waarvan je geen instantie kan maken
    * Doel: Overerving en een contract
    * Bevat abstracte en niet-abstracte methodes/properties
```csharp
public abstract Class Klasse
{
}
```
* Abstracte **methode/properties**
    * Enkel een abstracte klasse kan abstracte methode/property bevatten
    * Abstracte methode/property **_moeten_** geïmplementeerd worden in de subklasse
    * Een abstracte methode/property is impliciet een **_virtual_** methode/property
    * Abstracte methodes/properties zijn enkel geldig binnen een abstracte klasse
    * Een abstracte methode/property heeft geen body = geen implementatie

### - Interface
* Een interface is een "lege klasse" die enkel methodes en properties bevat **_zonder_** implementatie.
* Een interface kan **_niet_** geïnstantieerd worden = geen new keyword
* Het is een contract/definitie voor de klasse die de interface implementeert. 
* De klasse is **_verplicht_** om alles te implementeren
* Het beschrijft wat een (deel van de) klasse bevat.
* Een klasse kan **_meerdere_** interfaces implementeren.

### - Static
* Static klasse kan niet geïnstantieerd worden = geen new keyword
* Een static klasse heeft geen aanroepbare constructor
* Aanroepen via de klassenaam
* Doordat een static klasse geen instantie kan zijn, werk je tijdens de levensduur van je programma op hetzelfde object. Er is slechts één kopie van.
    * *Bewaren van gegevens op een static klasse kan gevaarlijk zijn!*
* Een klasse hoeft niet static te zijn om static members te hebben
* Er bestaat enkel één kopie van een static member
### - Generics
* generics laten je toe om een klasse, interface of methode te schrijven die kan werken met eender welk datatype
* Herkenbaar aan <*Kan gelijk welk letter/woord zijn*> in een klasse/type of methode

```csharp
// T wordt hier dus het specifieke type T, gekozen bij declaratie/initialisatie
public class WaardeEnBeschrijving<T>
{    
    public T Waarde { get; set; }
    public string Beschrijving { get; set; }
    public WaardeEnBeschrijving(T waarde, string beschrijving)
    {
        Waarde = waarde;
        Beschrijving = beschrijving;
    }
    // Dit is een generieke methode met generieke parameter P.    
    public P ReturnWaardeVanType<P>(P waarde)
    {
        return waarde;
    }
}
```