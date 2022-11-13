using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace _0_ToolBox
{
    //  RECURSIE
    //* Een methode die zichzelf aanroept
    //* Belangrijk! De methode moet een voorwaarde bevatten die de uitvoering stopt.Zo niet, dan blijft de methode oneindig lopen.



    internal class ToolBoxSamples
    {
        //Classes recap

        //###Overerven
        
        //#### Klasseniveau
        //* Je kan maar van één klasse erven
        //* Binnen een subklasse kunnen eigen variabelen, properties, methodes, … beschreven worden die niet in de superklasse voorkomen
        //* De constructor van de superklasse wordt niet geërfd.Iedere klasse heeft nog steeds eigen constructors
        //* Erven(inherit): een klasse kan de variabelen, properties, methodes, … overnemen van een andere klasse.
        //* This versus base
        //    * **_This:_** het huidige object waarop je werkt.De klasse waarin je bezig bent.
        //    *** _Base:_** het superklasse object van het huidige object

        //#### Methodeiveau
        //* Overschrijven van een methode of property van de superklasse 
        //* Een andere implementatie voorzien van een methode of property in de subklasse
        //* **Superklasse:** methode of property voorzien van het keyword** _virtual_**
        //    * Merkt de methode of property als overschrijfbaar
        //*** Subklasse:** methode of property voorzien van het keyword** _override_**
        //* Laat de compiler weten dat het een nieuwe implementatie is van een bestaande methode of property


        //### - Abstract

        //* Abstracte** klasse**
        //    * Klasse waarvan je geen instantie kan maken
        //    * Doel: Overerving en een contract
        //    * Bevat abstracte en niet-abstracte methodes/properties
        //```csharp
        //public abstract Class Klasse
        //        {
        //        }
        //```
        //* Abstracte** methode/properties**
        //    * Enkel een abstracte klasse kan abstracte methode/property bevatten
        //    * Abstracte methode/property** _moeten_** geïmplementeerd worden in de subklasse
        //    * Een abstracte methode/property is impliciet een **_virtual_** methode/property
        //    * Abstracte methodes/properties zijn enkel geldig binnen een abstracte klasse
        //    * Een abstracte methode/property heeft geen body = geen implementatie


        //### - Interface
        //* Een interface is een "lege klasse" die enkel methodes en properties bevat **_zonder_** implementatie.
            //* Een interface kan **_niet_** geïnstantieerd worden = geen new keyword
        //* Het is een contract/definitie voor de klasse die de interface implementeert. 
        //* De klasse is **_verplicht_** om alles te implementeren
        //* Het beschrijft wat een(deel van de) klasse bevat.
        //* Een klasse kan** _meerdere_** interfaces implementeren.

        //### - Static
        //* Static klasse kan niet geïnstantieerd worden = geen new keyword
        //* Een static klasse heeft geen aanroepbare constructor
        //* Aanroepen via de klassenaam
        //* Doordat een static klasse geen instantie kan zijn, werk je tijdens de levensduur van je programma op hetzelfde object. Er is slechts één kopie van.
        //    * *Bewaren van gegevens op een static klasse kan gevaarlijk zijn!*
        //* Een klasse hoeft niet static te zijn om static members te hebben
        //* Er bestaat enkel één kopie van een static member



        public int MyProperty1 { get; set; }//*** _"prop"_**
        
        private int myVar;//*** _"propfull"_**
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        //dictionary gebruiken voor LIJST van ValuePairs
        public Dictionary<DateTime, bool> _alarms;


        public string Naam { get; set; }
        public ToolBoxSamples(string naam)
        {
            Naam = naam;
            //!=null of ? is gelijk. VB met .Clear()
            if (_alarms != null)
            {
                _alarms?.Clear();
            }
            _alarms?.Clear();
        }

        internal string Type()
        {
            return "Methode om over te erven in subklasse";
        }

        //* **Superklasse:** methode of property voorzien van het keyword** _virtual_**
        //    * Merkt de methode of property als overschrijfbaar
        internal virtual string Type2()
        {
            return "Methode om te overschrijven in subklasse";
        }
    }

    internal class ToolBoxSamplesChild : ToolBoxSamples //klasse laten overerven
    {

        // : base() verwijst naar de constructor in de superklasse
        public ToolBoxSamplesChild(string naam) : base(naam)
        {

        }
        public string Type { get; }

        // : this() verwijst naar de constructor in de eigenklasse
        public ToolBoxSamplesChild(string naam, string type) : this(naam)
        {
            Type = type;
        }
        public string TypeAsString()
        {
            //verwijst naar een methode in de superclass
            return base.Type();
        }

        //*** Subklasse:** methode of property voorzien van het keyword** _override_**
        //* Laat de compiler weten dat het een nieuwe implementatie is van een bestaande methode of property
        internal override string Type2()
        {
            return "Methode om te overschrijven in subklasse";
        }
    }
    
    public enum EnumPeriod//Enumerator gebruiken om waardes te standaardiseren
    {
        Day,
        Evening
    }


}
