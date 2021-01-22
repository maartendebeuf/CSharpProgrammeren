using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld_Rekenmachine_v1
{
    public class Rekenmachine
    {
        // Bevat het resultaat
        private double resultaat;
        // Bevat de gekozen bewerking
        private string geselecteerdeBewerking;
        // Bevat het getal voor de bewerking
        private double eersteGetal;
        // Bevat het getal na de bewerking
        private double tweedeGetal;
        // True wanneer we reeds een resultaat berekend hebben voor de huidige getallen
        // False wanneer niet.
        private bool isResultaatBerekend;
        // Een lijst met alle geldige bewerkingen
        private List<string> geldigeBewerkingen = new List<string>() { "+", "-", "*", "/" };

        public bool IsResultaatBerekend()
        {
            return isResultaatBerekend;
        }

        public void BewaarGetal(double getal)
        {
            // Bij het bewaren van een getal zijn we zeker dat het resultaat nog niet berekend is.
            isResultaatBerekend = false;
            string volledigGetal;
            // Indien er nog geen bewerking geselecteerd is, zijn we nog steeds 
            // bezig met het ingeven van het eerste getal
            if (geselecteerdeBewerking == null)
            {
                // Maak er opnieuw een string van zodat we getallen aan elkaar kunnen kleven
                // vb.: 33
                volledigGetal = eersteGetal + "" + getal;
                eersteGetal = double.Parse(volledigGetal);
            }
            else
            {
                volledigGetal = tweedeGetal + "" + getal;
                tweedeGetal = double.Parse(volledigGetal);
            }
        }

        /// <summary>
        /// Bewaard de gekozen bewerking
        /// </summary>
        /// <param name="bewerking"></param>
        public void BewaarBewerking(string bewerking)
        {
            geselecteerdeBewerking = bewerking;
        }

        /// <summary>
        /// Controleert of de inputwaarde een geldige bewerking is
        /// </summary>
        /// <param name="bewerking"></param>
        /// <returns></returns>
        public bool IsGeldigeBewerking(string bewerking)
        {
            return geldigeBewerkingen.Contains(bewerking);
        }

        /// <summary>
        /// Het resultaat berekenen adhv de geselecteerde bewerking
        /// </summary>
        /// <returns></returns>
        public double BerekenResultaat()
        {
            switch (geselecteerdeBewerking)
            {
                case "+":
                    Toevoegen();
                    break;
                case "-":
                    Verminderen();
                    break;
                case "*":
                    Vermenigvuldigen();
                    break;
                case "/":
                    Delen();
                    break;
            }

            // Nu is het resultaat wel berekend. 
            // Markeer als 'true' zodat we het tekstveld bij de volgende berekening vrij kunnen maken
            isResultaatBerekend = true;
            // Reset alle variabelen die iets te maken hebben met het berekenen van het resultaat
            Reset();
            return resultaat;
        }

        // Alle methodes om bewerkingen uit te voeren zijn private,
        // want we gebruiken ze enkel binnen de klasse Rekenmachine
        private void Toevoegen()
        {
            resultaat = eersteGetal + tweedeGetal;
        }

        private void Verminderen()
        {
            resultaat = eersteGetal - tweedeGetal;
        }

        private void Vermenigvuldigen()
        {
            resultaat = eersteGetal * tweedeGetal;
        }

        private void Delen()
        {
            resultaat = eersteGetal / tweedeGetal;
        }

        /// <summary>
        /// Reset alle variabelen die een waarde bevatten om de huidige berekening uit te kunnen voeren
        /// </summary>
        private void Reset()
        {
            eersteGetal = 0;
            tweedeGetal = 0;
            geselecteerdeBewerking = null;
        }
    }
}
