using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._1.Basics.GoodToKnow
{
    internal class Switch
    {
        private void Main()
        {
            string input = "1";
            int getal = int.Parse(input);

            switch (getal)
            {
                case 4:
                    Console.WriteLine("Getal is 4");
                    break;
                case 5:
                    Console.WriteLine("Getal is 5");
                    break;
                case 3:
                    Console.WriteLine("Getal is 3");
                    break;
                case 2:
                case 8:
                    Console.WriteLine("Getal is 8 of 2");
                    break;
                default:
                    Console.WriteLine("Getal is onbekend");
                    break;
            }
        }
    }
}
