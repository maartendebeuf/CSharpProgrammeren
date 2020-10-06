# Oefeningen

## Debugging

Schrijf alle antwoorden op de vetgedrukte tekst in een markdown bestand en upload het nadien naar GitHub samen met het C# project.

1. Clone de C# repository van GitHub en kopieer het *Debugging project*  naar je eigen Git folder
2. Open het project  
   **Beschrijf kort wat je denkt dat het project bevat en doet.**
   **een simpele applicatie om denkbeeldige vormen te tekenen**
3. Start de debugger in Visual Studio (VS)  
   **Wat is de console output?**
4. Stop de debugger
5. Open het bestand `Program.cs` in VS en plaats een *breakpoint* op lijn 63 (`shape.Draw()`)
6. Navigeer via volgende manieren door de code. Herstart de debugger eens tussen beide manieren (Restart knop, Ctrl+Shift+F5) indien de applicatie niet wordt afgesloten.  
   **Beschrijf kort wat er gebeurt en wat de verschillen zijn tussen beide manieren.**
    1. Via *Step Into (F11)*
    2. Via *Step Over (F10)*  
7. Herstart de debugger en wacht tot je breakpoint geactiveerd is. Scroll daarna naar lijn 44 (` Console.WriteLine("Drawing a trangle");`) en hover over de lijn. Je ziet links een nieuwe knop tevoorschijn komen **(Run to click)**. Klik er op.    Alternatieve manier: Ctrl+F10 of rechtermuisknop -> run to cursor.  
![Run to click](../_other/images/runtoclick.png)  
   **Beschrijf kort wat er gebeurt.**
8. Pauzeer opnieuw je debugsessie op lijn 44. Verbeter nu de typefout (trangle -> tr**i**angle) tijdens je debugsessie. Navigeer een lijn verder (Step Into).  
   **Bekijk de console output. Wat zie je?**
9.  Activeer je breakpoint op lijn 63 opnieuw en hover over het woord *`shapes`*.  
**Wat zie je?**  
   Kijk nu ook eens in de *Autos* en *Locals windows*.  
   **Wat zie je daar? Kan je het verschil uitleggen tussen beide windows?**
11. Bekijk het *Callstack window*.  
    **Wat zie je daar? Kan je dit in eigen woorden uitleggen?**
12.  Plaats een breakpoint op lijn 25 (`base.Draw()`). Navigeer met *Step Into (F11)* tot je aan lijn 16 komt, net na `Console.WriteLine("Performing base class drawing tasks")`.  
**Wat is de console output tot dit punt?**  
Sleep nu de *gele pijl*, deze pijl toont waar je debugsessie momenteel gepauzeerd staat, één lijn omhoog tot op `Console.WriteLine("Performing base class drawing tasks")`. Navigeer opnieuw via *Step Into* een lijn verder.  
![Breakpoint arrow](../_other/images/breakpointarrow.png)  
**Bekijk opnieuw de console output. Kan je beschrijven wat er is gebeurd?**

## Exceptions

1. Boek p34: Voorbeeld foutafhandeling
2. Boek p37: Opdracht Foutmelding 1: Messagebox (opdracht variabelen is te vinden op p32)
3. Kan je in je eigen woorden uitleggen wat `Exceptions` zijn en waarvoor ze dienen? 

### Extra

Hieronder vind je een lijst van veel voorkomende `exceptions`. Kan je, na het lezen van de naam, gokken wanneer/waarom de `exception` wordt opgesmeten? Zoek daarna via Google naar het correcte antwoord. Noteer alles in een markdown bestand en upload het naar GitHub.
   * InvalidOperationException
   * StackOverflowException
   * OutOfMemoryException
   * AccessException
   * ArithmeticException
   * DevideByZeroException
   * FormatException
   * InvalidCastException
   * NotSupportedException
   * Exception