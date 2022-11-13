using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView.GoodToKnow
{
    internal class Dictionary
    {

        //dictionary gebruiken voor lijst van valuepairs
        public Dictionary<DateTime, bool> _alarms;
        static void Main(string[] args)
        {
            var getallenAlsLijst = new List<int>()
            {
                1, 2, 3
            };

            // Toevoegen
            getallenAlsLijst.Add(4);
            getallenAlsLijst.Add(5);
            getallenAlsLijst.Add(6);

            // Toevoegen op bepaalde index
            getallenAlsLijst.Insert(0, 23);

            // Aanpassen
            getallenAlsLijst[2] = 45;

            // Verwijderen waarde
            getallenAlsLijst.Remove(1);

            // Verwijderen via index
            getallenAlsLijst.RemoveAt(2);


            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                // Accolades om KeyValuePair aan te duiden!
                {"abc", "def"}
            };

            // Toevoegen
            dictionary.Add("Lowie", "Delneste");
            dictionary.Add("Joeri", "Rosseel");
            dictionary["Koen"] = "Demey";

            // Itereren
            foreach (var keyValuePair in dictionary)
            {
                var sleutel = keyValuePair.Key;
                var waarde = keyValuePair.Value;
                Console.WriteLine(sleutel + waarde);
            }

            // Controleren of de sleutel bestaat en opvragen waarde via key
            if (dictionary.ContainsKey("Lowie"))
            {
                var achternaamLowie = dictionary["Lowie"];
            }

            // Controleren of de waarde aanwezig is
            dictionary.ContainsValue("Delneste");

            // Controleren sleutel/waarde combinatie aanwezig is
            dictionary.Contains(new KeyValuePair<string, string>("Koen", "Demey"));

            // Opvragen List<> van keys of waardes
            var lijstVanSleutels = dictionary.Keys;
            var lijstVanWaardes = dictionary.Values;
        }

    }
}
