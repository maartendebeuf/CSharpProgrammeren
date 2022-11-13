using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;
using System;

namespace ToDoLijst
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TodoView());
        }
    }
    //Maak een winforms applicatie aan met volgende functionaliteit: (Werk object geörienteerd) --ok
    //● Maak een scherm met een generieke lijst van todo items.--ok
    //(Abstracte klasse TodoItem en de --ok
    //    afgeleide klasses HomeWork & OutsideWork.Zorg voor minstens volgende properties: Name, --ok
    //Description, DueDate, ExecuterName, Location, DateExecuted) --ok
    //● Maak een extra scherm voor het kunnen toevoegen van items aan de todo lijst.--ok
    //○ Bij het toevoegen van een item is het de bedoeling dat er gewerkt wordt met een event.--ok
    //○ De DueDate moet in de toekomst liggen, als deze niet in de toekomst ligt moet er een exception worden opgeroepen --ok 
    //○ Het is mogelijk om meerdere items toe te voegen in het extra scherm--ok 
    //● Maak het mogelijk om een taak af te werken (invullen van de property DateExecuted) --ok
    //● Toon met LINQ de todo lijst op volgende wijzes(toon het resultaat in de lijst) :
    //○ Gegroepeerd per week het aantal todo’s: ‘10/10/2022 - 16/10/2022: 4’
    //○ Gegroepeerd per executer: ‘Arne: 3’
    //○ Alle uitgevoerde taken: ‘DateExecuted: Name, Description’
    //○ Alle taken die de komende 7 dagen moeten worden uitgevoerd: ‘Name, Description’
    //● Maak het mogelijk om een lijst van todo’s te importeren. (zorg dat deze functionaliteit asynchroon
    //loopt)
    //● Log volgende acties naar een bestand:
    //○ Aanmaken todo item
    //○ Verwijderen todo item
    //○ Importeren van lijst(log het # aantal items die werden toegevoegd)
}