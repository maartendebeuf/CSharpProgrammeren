using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2
{
    /*
    Voorzie een `MathUtil` klasse die een aantal basis rekenkundige bewerkingen bevat:
    * Plus(eersteGetal, tweedeGetal)
    * Min(eersteGetal, tweedeGetal)
    * Maal(eersteGetal, tweedeGetal)
    * Delen(teDelenGetal, deelGetal)
    * Percentage(getal, percentageGetal)
    */
    class MathUtil
    {
        public static double Plus(double eersteGetal, double tweedeGetal)
        {
            return eersteGetal + tweedeGetal;
        }
        public static double Min(double eersteGetal, double tweedeGetal)
        {
            return eersteGetal - tweedeGetal;
        }
        public static double Maal(double eersteGetal, double tweedeGetal)
        {
            return eersteGetal * tweedeGetal;
        }
        public static double Delen(double eersteGetal, double tweedeGetal)
        {
            return eersteGetal / tweedeGetal;
        }
        public static double Percentage(double getal, double percentageGetal)
        {
            return (getal / percentageGetal)*100;
        }
    }
}
