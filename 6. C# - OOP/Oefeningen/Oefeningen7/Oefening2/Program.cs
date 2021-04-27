using System;

namespace Oefening2
{
    class Program
    {
        /*
        Voorzie een `MathUtil` klasse die een aantal basis rekenkundige bewerkingen bevat:
        * Plus(eersteGetal, tweedeGetal)
        * Min(eersteGetal, tweedeGetal)
        * Maal(eersteGetal, tweedeGetal)
        * Delen(teDelenGetal, deelGetal)
        * Percentage(getal, percentageGetal)

        Maak gebruik van statische methodes en zorg ervoor dat de applicatie werkt met kommagetallen. Ingave van bewerkingen is niet hoofdlettergevoelig!\
        Laat de applicatie bewerkingen uitvoeren tot de gebruiker 'einde' typt.

        ### Voorbeeld input

        | Input      | Output |
        | ---------- | ------ |
        | Plus 5 5   | 10     |
        | Min 5,5 11 | 60,5   |
        | Delen 10 2 | 5      |
        | ...        | ...    |
        | Einde      |        |
        */
        static void Main(string[] args)
        {
            Console.WriteLine("geef het bewerkingstype en de waardes in gescheiden door een spatie");
            bool beeindigd = false;
            do
            {  
                string bewerking = Console.ReadLine();
                if (bewerking.ToLower() == "einde")
                {
                    beeindigd = true;
                }
                else 
                {
                    Bewerking(bewerking);
                }

            } while (!beeindigd);
            
        }
        public static void Bewerking(string bewerking)
        {
            try
            {
                var waardes = bewerking.Split(" ");
                string bewerkingstype = waardes[0];
                double waarde1 = double.Parse(waardes[1]);
                double waarde2 = double.Parse(waardes[2]);

                switch (bewerkingstype.ToLower())
                {
                    case "plus":
                        Console.WriteLine(MathUtil.Plus(waarde1, waarde2));
                        break;
                    case "min":
                        Console.WriteLine(MathUtil.Min(waarde1, waarde2));
                        break;
                    case "maal":
                        Console.WriteLine(MathUtil.Maal(waarde1, waarde2));
                        break;
                    case "delen":
                        Console.WriteLine(MathUtil.Delen(waarde1, waarde2));
                        break;
                    case "percentage":
                        Console.WriteLine(MathUtil.Percentage(waarde1, waarde2));
                        break;
                    default:
                        break;
                }

            }
            catch (Exception)
            {

            }                        
        }
    }
}
