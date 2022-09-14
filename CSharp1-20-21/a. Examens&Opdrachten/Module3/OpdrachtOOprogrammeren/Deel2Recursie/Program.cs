using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel2Recursie
{
    class Program
    {
        //Deel 2 Recursie
        //Maak een programma waarmee je de som van alle cijfers in een natuurlijk getal kan berekenen via recursie. 
        //Schrijf een methode som(int getal) die via recursie de cijfersom uitvoert. 
        //De som van alle getallen wordt berekend door de formule getal % 10 + som(getal  10). 
        //De deling door 10 is een natuurlijke deling door 10, wat wil zeggen dat het resultaat van de deling geen kommagetal is (natuurlijk getal). 
        //Als de natuurlijke deling door 10 als resultaat 0 geeft, dan is de uitvoering compleet.  

        static void Main(string[] args)
        {
            Recursie recursie = new Recursie();
            int resultaat = recursie.NatuurlijkGetal(234);
            Console.WriteLine("Waarde: " + resultaat);
            Console.ReadKey();
        }
    }
}
