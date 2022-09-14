using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    public class Werknemer
    {
        //## Oefening 2

        //Maak onderstaande oefening in WPF.
        //Zorg ervoor dat we een ongelimiteerd aantal werknemers kunnen aanmaken. Voorzie dus een lijst van werknemers.\
        //In een bedrijf werken drie soorten werknemers: arbeiders, bedienden en kaderleden. Ontwerp voor ieder een aparte klasse.\
        //Alle **werknemers** hebben een voornaam en een naam.\
        //**Arbeiders** ontvangen een uurloon daarom is het belangrijk om voor iedere arbeider bij te houden het aantal gewerkte uren in 
        //de afgelopen maand.\
        //**Bedienden** en **kaderleden** krijgen een maandwedde uitbetaald en ontvangen maaltijdcheques. Het aantal maaltijdcheques komt overeen met het aantal gewerkte dagen.\
        //**Kaderleden** hebben recht op een bedrijfswagen. Van de kaderleden wordt bijgehouden welk type auto ze hebben.\
        //Maak gebruik van overerving bij het oplossen van deze oefening.
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public Werknemer(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
        }
    }
}
