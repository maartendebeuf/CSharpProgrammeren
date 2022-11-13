using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView.GoodToKnow
{
    //Moet dit in een Class staan? geen foutmelding bij beide
    internal class Enum
    {
        //Enumerator gebruiken om waardes te standaardiseren
        public enum EnumPeriod
        {
            Day,
            Evening,
            Noon
        }
    }
    public enum EnumPeriod
    {
        Day,
        Evening,
        Noon
    }
}
