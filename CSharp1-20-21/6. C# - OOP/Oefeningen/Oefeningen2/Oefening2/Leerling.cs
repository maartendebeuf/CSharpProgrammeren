using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    //## Oefening 2

    //Ontwerp een applicatie voor de opslag van de gegevens van leerlingen.
    //Sla de voornaam, de naam en de klas op.
    //Geef de klasse een constructor waaraan je de voornaam, naam en klas kan meegeven als parameter.
    //Zorg ervoor dat alle gegevens nog aangepast kunnen worden.

    class Leerling
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Klas { get; set; }
        
        public Leerling(string inpVoornaam, string inpNaam, string inpKlas)
        {
            Voornaam = inpVoornaam;
            Naam = inpNaam;
            Klas = inpKlas;
        }

        public void UpdateLeerling(string inpVoornaam, string inpNaam, string inpKlas)
        {
            if (!string.IsNullOrWhiteSpace(inpVoornaam))
            {
                Voornaam = inpVoornaam;
            }
            if (!string.IsNullOrWhiteSpace(inpNaam))
            {
                Naam = inpNaam;
            }
            if (!string.IsNullOrWhiteSpace(inpKlas))
            {
                Klas = inpKlas;
            }
        }

        public string GetLeelingInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Voornaam: " + Voornaam);
            stringBuilder.AppendLine("Naam: " + Naam);
            stringBuilder.AppendLine("Klas: " + Klas);

            return stringBuilder.ToString();
        }

    }
}
