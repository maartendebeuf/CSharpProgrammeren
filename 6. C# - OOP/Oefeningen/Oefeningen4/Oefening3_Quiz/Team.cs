using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3_Quiz
{
    public class Team : Object
    {
        //## Oefening 3

        //Pas de oefening Team van een vorige les aan. 
        //In die oefening hebben we gebruik gemaakt van een methode Print(). 
        //Zorg er nu voor dat je gebruik maakt van de ToString() methode van Object om de 
        //gegevens van de leden en van het team weer te geven in de console. 
        //Verwijder daarna de Print() methode.\
        //Maak gebruik van het **override** keyword.


        // We moeten alle leden ergens bewaren zodat we ze later
        // kunnen aanroepen om alle gegevens te printen.
        // Dit kunnen we doen met een List<T>
        // Private set => Ledenlijst niet van buitenaf initialiseren
        public List<Lid> Ledenlijst { get; private set; }

        // Constructor die de leden zelf aanmaakt
        public Team()
        {
            // Initialiseren van de lijst
            Ledenlijst = new List<Lid>();

            // Vier leden aanmaken en toevoegen aan de lijst
            // Mogelijkheid 1: aanmaken van een lid en toevoegen aan de lijst
            var lid1 = new Lid("Lid 1 Alpha", "Sport");
            var lid2 = new Lid("Lid 2 Alpha", "Dans");
            Ledenlijst.Add(lid1);
            Ledenlijst.Add(lid2);
            // Mogelijkheid 2: Lid onmiddelijk toevoegen aan de lijst
            Ledenlijst.Add(new Lid("Lid 3 Alpha", "Muziek"));
            Ledenlijst.Add(new Lid("Lid 4 Alpha", "Film"));

            // Mogelijkheid 4: Alle leden toevoegen tijdens het initialiseren van de lijst
            //ledenlijst = new List<Lid>
            //{
            //    new Lid("Lid 1 Alpha", "Sport"),
            //    new Lid("Lid 2 Alpha", "Dans"),
            //    new Lid("Lid 3 Alpha", "Muziek"),
            //    new Lid("Lid 4 Alpha", "Film")
            //};
        }

        // Constructor die een lijst van leden verwacht
        public Team(List<Lid> nieuweLedenlijst)
        {
            // this is hier optioneel
            Ledenlijst = nieuweLedenlijst;
        }

        public string PrintAlleLeden()
        {
            var stringBuilder = new StringBuilder();
            // Overlopen van alle leden in de lijst
            foreach (var lid in Ledenlijst)
            {
                stringBuilder.AppendLine(lid.ToString());
            }

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return PrintAlleLeden();
        }

        public bool IsMaximumLedenBereikt()
        {
            return Ledenlijst.Count == 4;
        }

        public bool IsGeldigLid(Lid nieuwLid)
        {
            return !string.IsNullOrEmpty(nieuwLid.Naam) && !string.IsNullOrEmpty(nieuwLid.Specialiteit);
        }
    }
}
