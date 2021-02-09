using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    //Quiz123 houdt de gegevens bij van de aangesloten quiz-teams.
    //Ieder team bestaat uit 4 leden.Elk lid heeft een bepaalde specialiteit, bijvoorbeeld sport, film en muziek,…\

    ////Maak een klasse Lid.Geef de klasse een constructor waarmee je de naam van het lid en zijn/haar specialiteit kan invoeren. 
    //Geef de klasse ook een methode Print( ) die de properties van het betreffende lid op het scherm weergeeft.\

    //Maak een klasse Team die 4 instanties van Lid maakt. 
    //Geef de klasse een methode PrintAlleLeden() die de namen van de leden en hun specialiteiten op het scherm toont.\
    //Voorzie twee constructors, één waar de leden in de constructor aangemaakt worden en één waar je een lijst van leden aan kan meegeven.
    class Team
    {
        private Lid Lid1 { get; set; }
        private Lid Lid2 { get; set; }
        private Lid Lid3 { get; set; }
        private Lid Lid4 { get; set; }

        public Team(List<Lid> inpLedenlijst)
        {
            Lid1 = inpLedenlijst[0];
            Lid2 = inpLedenlijst[1];
            Lid3 = inpLedenlijst[2];
            Lid4 = inpLedenlijst[3];            
        }
        public Team(Lid inpLid1, Lid inpLid2, Lid inpLid3, Lid inpLid4)
        {
            Lid1 = inpLid1;
            Lid2 = inpLid2;
            Lid3 = inpLid3;
            Lid4 = inpLid4;
        }
        public void PrintAlleLeden()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Lid1:");
            stringBuilder.AppendLine("Lid1:");
        }
    }
}
