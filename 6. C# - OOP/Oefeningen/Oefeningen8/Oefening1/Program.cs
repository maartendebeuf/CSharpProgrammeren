using System;

namespace Oefening1
{
    class Program
    {
        //Voorzie een generieke klasse `Box` die een variabele van eender welk type verwacht en bewaart. 
        //Overschrijf de `ToString()` methode zodat die het exacte type en de waarde retourneert als **type class full name: value**.

        //**TIP:** om de volledige klassenaam van een type op te vragen, maak je gebruik van `[variabele].GetType().FullName`.
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>("string");
            var typenaam = box.ToString();
            Console.WriteLine(typenaam);

            Box<int> box2 = new Box<int>(5);
            var typenaam2 = box2.ToString();
            Console.WriteLine(typenaam2);

            Box<object> box3 = new Box<object>(5);
            var typenaam3 = box3.ToString();
            Console.WriteLine(typenaam3);

            Box2 box21 = new Box2();
            box21.Input("string");
            Console.WriteLine(box21.ToString());
            box21.Input(1);
            Console.WriteLine(box21.ToString());

        }
    }
}
