using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vraag een nummer X en vul daarmee een Dictionary<T> waarvan de key X is en de waarde X*X is, waarbij X 
            //start bij 1.Toon daarna alle paren(key / value).\
            //Vb: X = 4-> { 1,1}
            //{ 2,4}
            //{ 3,9}
            //{ 4,16}
            Console.WriteLine("Geef een aantal in.");
            int aantal = int.Parse(Console.ReadLine());            
            var namen = new List<string>();
            Dictionary<int, int> paren = new Dictionary<int, int>();
            for (int i = 1; i <= aantal; i++)
            {
                paren.Add(i, (i * i));
            }
            foreach(var paar in paren)
            {
                Console.WriteLine("{" + paar.Key + ", " + paar.Value + "}");
            }
            Console.ReadLine();
        }
    }
}
