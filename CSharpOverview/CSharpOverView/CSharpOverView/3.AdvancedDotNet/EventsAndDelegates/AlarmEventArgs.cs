using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._3.AdvancedDotNet.EventsAndDelegates
{
    internal class AlarmEventArgs : EventArgs
    {
        public DateTime Alarm { get; set; }

        public AlarmEventArgs(DateTime alarm)// DateTime instellen om als arg terug te kunnen geven bij opvangen Event
        {
            Alarm = alarm;
        }
    }
}
