using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView.GoodToKnow
{
    internal class Not_null
    {
        //dictionary gebruiken voor LIJST van ValuePairs
        public Dictionary<DateTime, bool> _alarms;


        public string Naam { get; set; }
        public Not_null(string naam)
        {
            Naam = naam;
            //!=null of ? is gelijk. Voorbeeld met .Clear()
            if (_alarms != null)
            {
                _alarms?.Clear();
            }
            _alarms?.Clear();
        }
    }
}
