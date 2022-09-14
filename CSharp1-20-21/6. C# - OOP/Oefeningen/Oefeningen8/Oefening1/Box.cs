using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    //Voorzie een generieke klasse `Box` die een variabele van eender welk type verwacht en bewaart. 
    //Overschrijf de `ToString()` methode zodat die het exacte type en de waarde retourneert als **type class full name: value**.

    //**TIP:** om de volledige klassenaam van een type op te vragen, maak je gebruik van `[variabele].GetType().FullName`.
    public class Box<T>
    {     
        T Variabele { get; set; }
        public Box(T variabele)
        {
            Variabele = variabele; 
        }
        public override string ToString()
        {
            return $"type class full name: {Variabele.GetType().FullName}";
        }
    }
}
