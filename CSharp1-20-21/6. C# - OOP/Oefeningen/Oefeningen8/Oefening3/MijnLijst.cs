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
    //* `T Last()`\
    //Retourneer het laatste element
    //* `T First()`\
    //Retourneer het eerste element
    class MijnLijst
    {
        public void Run(object o1, object o2, object o3, object o4, object o5)
        {
            MijnLijst mijnLijstString = new MijnLijst();
            mijnLijstString.List.Add(o1);
            Console.WriteLine(mijnLijstString.ToString());
            mijnLijstString.List.Add(o2);
            Console.WriteLine(mijnLijstString.ToString());
            mijnLijstString.List.Add(o3);
            Console.WriteLine(mijnLijstString.ToString());
            mijnLijstString.List.Add(o4);
            Console.WriteLine(mijnLijstString.ToString());
            mijnLijstString.Add(o5);
            Console.WriteLine(mijnLijstString.ToString());
            mijnLijstString.Remove(2);
            Console.WriteLine(mijnLijstString.ToString());
            Console.WriteLine(mijnLijstString.Contains(o3));
            Console.WriteLine(mijnLijstString.Last());
            Console.WriteLine(mijnLijstString.First());
        }

        public List<object> List { get; set; } = new List<object>();
        public void Add<T>(T element)
        {
            List.Add(element);
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public bool Contains<T>(T element)
        {
            return List.Contains(element);
        }
        public object Last()
        {
            return List[^1];
        }
        public object First()
        {
            return List[0];
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in List)
            {
                stringBuilder.Append( " " + item.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
