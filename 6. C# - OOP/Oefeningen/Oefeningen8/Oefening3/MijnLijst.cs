using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening3
{
    //Maak een eigen implementatie van een generieke lijst. Implementeer onderstaande methodes:
    //* `void Add(T element)`\
    //Voeg het element toe aan het einde van de lijst
    //* `T Remove(int index)`\
    //Verwijder het element dat zich op de index bevindt uit de lijst
    //* `bool Contains(T element)`\
    //Controleer of het element zich in de lijst bevindt (true/false)
    //* `T Max()`\
    //Retourneer het laatste element
    //* `T Min()`\
    //Retourneer het eerste element
    class MijnLijst 
    {
        public List<object> List { get; set; } = new List<object>();
        public void Add<T>(T element)
        {
            List.Add(element);
        }
        public void Remove(int index)
        {
            
        }
        public bool Contains<T>(T element)
        {
            return List.Contains(element);
        }
    }
}
