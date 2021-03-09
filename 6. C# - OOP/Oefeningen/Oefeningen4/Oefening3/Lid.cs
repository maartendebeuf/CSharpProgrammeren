using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Oefening3
{
    //Quiz123 houdt de gegevens bij van de aangesloten quiz-teams.
    //Ieder team bestaat uit 4 leden.Elk lid heeft een bepaalde specialiteit, bijvoorbeeld sport, film en muziek,…\

    ////Maak een klasse Lid.Geef de klasse een constructor waarmee je de naam van het lid en zijn/haar specialiteit kan invoeren. 
    //Geef de klasse ook een methode Print( ) die de properties van het betreffende lid op het scherm weergeeft.\

    //Maak een klasse Team die 4 instanties van Lid maakt. 
    //Geef de klasse een methode PrintAlleLeden() die de namen van de leden en hun specialiteiten op het scherm toont.\
    //Voorzie twee constructors, één waar de leden in de constructor aangemaakt worden en één waar je een lijst van leden aan kan meegeven.
    class Lid
    {
        public string LidNaam { get; set; }
        public string LidSpecialiteit { get; set; }

        public Lid(string inpLidNaam, string inpLidSpecialiteit)
        {
            LidNaam = inpLidNaam;
            LidSpecialiteit = inpLidSpecialiteit;
        }

        public void PrintLid()
        {
            MessageBox.Show($"Naam = {LidNaam}, Specialiteit = {LidSpecialiteit}");
        }
    }
}
