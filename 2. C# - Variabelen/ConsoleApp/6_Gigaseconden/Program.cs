using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Gigaseconden
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bereken hoe lang iemand reeds leeft in gigaseconden (=1.000.000.000s)
            
            DateTime dateTime = new DateTime();
            int gigaseconden = 1000000000;
            DateTime newDateTime = dateTime.AddSeconds(gigaseconden);
            int jaar = newDateTime.Year;
            int maand = newDateTime.Month;
            int dagen = newDateTime.Day;
            int uren = newDateTime.Hour;
            int minuten = newDateTime.Minute;
            int seconden = newDateTime.Second;
            Console.WriteLine("Iemand dat " + gigaseconden + " gigaseconden leeft is:");
            Console.WriteLine(jaar + " jaar, " + maand + " maand, " + dagen + " dagen, " + uren + " uren, " + minuten + " minuten, " + seconden + " seconden oud");
            Console.ReadLine();

        }
    }
}
