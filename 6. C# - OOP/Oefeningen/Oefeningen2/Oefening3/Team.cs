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
    class Team
    {
        private string TeamNaam { get; set; }
        private Lid Lid1 { get; set; }
        private Lid Lid2 { get; set; }
        private Lid Lid3 { get; set; }
        private Lid Lid4 { get; set; }

        public Team(string inpTeamNaam, List<Lid> inpLedenlijst)
        {
            if (inpLedenlijst.Count == 4) 
            {
                TeamNaam = inpTeamNaam;
                Lid1 = inpLedenlijst[0];
                Lid2 = inpLedenlijst[1];
                Lid3 = inpLedenlijst[2];
                Lid4 = inpLedenlijst[3];
            }
            else if (inpLedenlijst.Count < 4)
            {
                MessageBox.Show("Te weinig leden.");
            }
            else if (inpLedenlijst.Count > 4)
            {
                MessageBox.Show("Te veel leden.");
            }
        }
        public Team(string inpTeamNaam, string inpLidNaam1, string inpLidSpecialiteit1
            , string inpLidNaam2, string inpLidSpecialiteit2
            , string inpLidNaam3, string inpLidSpecialiteit3
            , string inpLidNaam4, string inpLidSpecialiteit4)
        {
            Lid1 = new Lid(inpLidNaam1, inpLidSpecialiteit1);
            Lid2 = new Lid(inpLidNaam2, inpLidSpecialiteit2);
            Lid3 = new Lid(inpLidNaam3, inpLidSpecialiteit3);
            Lid4 = new Lid(inpLidNaam4, inpLidSpecialiteit4);
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
            stringBuilder.AppendLine("Lid2:");
            stringBuilder.AppendLine("Lid3:");
            stringBuilder.AppendLine("Lid4:");
        }
    }
}
