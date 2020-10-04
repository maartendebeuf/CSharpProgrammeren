using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Is een jaar een schrikkeljaar of niet?
            Een schrikkeljaar is:    
            * Restloos deelbaar door 4, maar niet door 100
            * Of restloos deelbaar door 400
            */
            Console.WriteLine("geef een jaar in: ");
            int year = int.Parse(Console.ReadLine());
            bool per4 = year % 4 == 0;
            bool per100 = year % 100 == 0;
            bool per400 = year % 400 == 0;
            bool schrikkeljaar = !per100 && per4 || per400;
            //Console.WriteLine(per4);
            //Console.WriteLine(per100);
            //Console.WriteLine(per400);
            Console.WriteLine(schrikkeljaar);
            Console.ReadKey();
        }
    }
}
