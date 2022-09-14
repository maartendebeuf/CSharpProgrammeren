using System;

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
    class Program
    {        
        static void Main(string[] args)
        {
            MijnGenericLijst<string> mijnGenericLijstString = new MijnGenericLijst<string>();
            mijnGenericLijstString.List.Add("eerste");
            Console.WriteLine(mijnGenericLijstString.ToString());
            mijnGenericLijstString.List.Add("tweede");
            Console.WriteLine(mijnGenericLijstString.ToString());
            mijnGenericLijstString.List.Add("derde");
            Console.WriteLine(mijnGenericLijstString.ToString());
            mijnGenericLijstString.List.Add("vierde");
            Console.WriteLine(mijnGenericLijstString.ToString());
            mijnGenericLijstString.Add("vijfde");
            Console.WriteLine(mijnGenericLijstString.ToString());
            mijnGenericLijstString.Remove(2);
            Console.WriteLine(mijnGenericLijstString.ToString());
            Console.WriteLine(mijnGenericLijstString.Contains("derde"));
            Console.WriteLine(mijnGenericLijstString.Last());
            Console.WriteLine(mijnGenericLijstString.First());

            MijnGenericLijst<int> mijnGenericLijstInt  = new MijnGenericLijst<int>();
            mijnGenericLijstInt.List.Add(1);
            Console.WriteLine(mijnGenericLijstInt.ToString());
            mijnGenericLijstInt.List.Add(2);
            Console.WriteLine(mijnGenericLijstInt.ToString());
            mijnGenericLijstInt.List.Add(3);
            Console.WriteLine(mijnGenericLijstInt.ToString());
            mijnGenericLijstInt.List.Add(4);
            Console.WriteLine(mijnGenericLijstInt.ToString());
            mijnGenericLijstInt.Add(5);
            Console.WriteLine(mijnGenericLijstInt.ToString());
            mijnGenericLijstInt.Remove(2);
            Console.WriteLine(mijnGenericLijstInt.ToString());
            Console.WriteLine(mijnGenericLijstInt.Contains(3));           
            Console.WriteLine( mijnGenericLijstInt.Last());
            Console.WriteLine(mijnGenericLijstInt.First());

            MijnLijst mijnLijst = new MijnLijst();
            RunMijnLijst(mijnLijst, 1, "twee", 3, "vier", 5);
        }
        public static void RunMijnLijst(MijnLijst mijnLijst, object o1, object o2, object o3, object o4, object o5)
        {
            mijnLijst.List.Add(o1);
            Console.WriteLine(mijnLijst.ToString());
            mijnLijst.List.Add(o2);
            Console.WriteLine(mijnLijst.ToString());
            mijnLijst.List.Add(o3);
            Console.WriteLine(mijnLijst.ToString());
            mijnLijst.List.Add(o4);
            Console.WriteLine(mijnLijst.ToString());
            mijnLijst.Add(o5);
            Console.WriteLine(mijnLijst.ToString());
            mijnLijst.Remove(2);
            Console.WriteLine(mijnLijst.ToString());
            Console.WriteLine(mijnLijst.Contains(o3));
            Console.WriteLine(mijnLijst.Last());
            Console.WriteLine(mijnLijst.First());
        }
    }
}
