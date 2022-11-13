using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._1.Basics.Classes
{
    internal class GenericClass
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lijstHelper = new LijstHelper();
            Console.WriteLine("Lijst met integers");
            lijstHelper.VoerUit<int>();
            Console.WriteLine("Lijst met string");
            lijstHelper.VoerUit<string>();
            Console.WriteLine("Lijst met bool");
            lijstHelper.VoerUit<bool>();
        }
    }
    public class LijstHelper
    {
        public void VoerUit<T>()
        {
            // Stap 1: opvragen aantal elementen
            var aantalElementen = VraagAantalElementen();
            if (aantalElementen == 0)
            {
                // VraagAantal() retourneert 0 als het aantal elementen niet correct is. 
                // Stop executie van de code
                return;
            }

            // Stap 2: Opvragen van de elementen
            var elementen = VraagElementen<T>(aantalElementen);
            if (elementen == null)
            {
                // VraagElementen() retourneert null als de ingegeven elementen niet correct zijn. 
                // Stop executie van de code
                return;
            }

            // Stap 3: Opvragen van de indexes v/d waardes die gewisseld moeten worden
            var indexes = VraagTeWisselenIndexes(aantalElementen);
            if (indexes == null)
            {
                // VraagIndexes() retourneert null als de ingegeven indexes niet correct zijn. 
                // Stop executie van de code
                return;
            }

            // Stap 4: Wissel de elementen
            var index1 = indexes[0];
            var index2 = indexes[1];
            var lijstMetGewisseldeElementen = WisselElementen<T>(elementen, index1, index2);

            // Stap 5: Print de lijst
            foreach (var item in lijstMetGewisseldeElementen)
            {
                Console.Write(item + " ");
            }
            // \n == nieuwe lijn
            Console.WriteLine("\n------------------------------");
        }

        private List<T> WisselElementen<T>(List<T> lijst, int index1, int index2)
        {
            var eersteItem = lijst[index1];
            var tweedeItem = lijst[index2];

            // Wissel items
            lijst[index1] = tweedeItem;
            lijst[index2] = eersteItem;

            return lijst;
        }

        private int VraagAantalElementen()
        {
            Console.WriteLine("Geef het aantal elementen in");
            // Vraag getal op en probeer de string om te zetten naar een getal
            var getalInput = Console.ReadLine();
            // Als het omzetten lukt wordt het getal bewaard in de variabele 'aantalElementen'
            var isGetal = int.TryParse(getalInput, out int aantalElementen);
            // Controleer of de variabele aantal een geldige waarde bevat
            if (!isGetal || !GeldigAantal(aantalElementen))
            {
                Console.WriteLine("Aantal elementen is niet geldig. Moet een getal zijn en groter zijn dan 1.");
                // Stop executie van de code
                return 0;
            }

            return aantalElementen;
        }

        private List<T> VraagElementen<T>(int aantalElementen)
        {
            Console.WriteLine($"Geef de elementen ({aantalElementen}) in gescheiden door een spatie");
            var elementenAlsString = VraagDataGesplitsPerSpatie();
            // Controleer of het aantal elementen in de lijst gelijk is aan de variabele aantalElementen
            if (elementenAlsString.Length != aantalElementen)
            {
                Console.WriteLine("Het aantal ingegeven elementen is niet geldig! U gaf te veel of te weinig elementen in.");
                // Stop executie van de code
                return null;
            }

            // Converteer alle strings naar het type T
            var elementenAlsT = new List<T>();
            foreach (var item in elementenAlsString)
            {
                // Converteer item naar type van T.
                // Uit ChangeType() komt een object van type Object en dit kan niet in onze lijst van T, dus converteren naar type T => (T)
                // https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype
                var geconverteerdItem = (T)Convert.ChangeType(item, typeof(T));
                elementenAlsT.Add(geconverteerdItem);
            }

            return elementenAlsT;
        }

        private List<int> VraagTeWisselenIndexes(int lengteVanDeLijst)
        {
            try
            {
                Console.WriteLine("Geef de te wisselen indexes");
                var indexes = VraagDataGesplitsPerSpatie();

                // Converteer de indexes naar int
                var index1 = int.Parse(indexes[0]);
                var index2 = int.Parse(indexes[1]);

                // Controleer of de indexes geldig zijn
                if (!GeldigeIndex(index1, lengteVanDeLijst) || !GeldigeIndex(index2, lengteVanDeLijst))
                {
                    Console.WriteLine("Indexes niet geldig");
                    // Stop executie van de code
                    return null;
                }

                // Retourneer een nieuwe lijst met beide indexes
                return new List<int> { index1, index2 };
            }
            catch (Exception)
            {
                Console.WriteLine("Indexes niet geldig");
                return null;
            }
        }

        private string[] VraagDataGesplitsPerSpatie()
        {
            var input = Console.ReadLine();
            // Splits de input op de spaties en verwijder lege elementen (bijvoorbeeld twee spaties)
            var inputAlsStringList = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            // Return de array van input data
            return inputAlsStringList;
        }

        private bool GeldigAantal(int aantal)
        {
            return aantal > 1;
        }

        /// <summary>
        ///  Controleert of de index geldig is. De index moet groter zijn dan nul en kleinder dan de lengte van de lijst
        /// </summary>
        /// <param name="index"></param>
        /// <param name="lengteVanDeLijst"></param>
        /// <returns></returns>
        private bool GeldigeIndex(int index, int lengteVanDeLijst)
        {
            return index >= 0 && index < lengteVanDeLijst;
        }
    }
}
