using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpOverView._3.AdvancedDotNet.EventsAndDelegates
{
    internal class Clock
    {
        private Timer _timer;
        private bool _alarmHasBeenTriggered = false;
        private Dictionary<DateTime, bool> _alarms;//dictionary gebruiken voor LIJST van ValuePairs

        public event AlarmEventHandler AlarmTriggered;//Wordt Initiated in program bij aanmaken nieuw object van _thisClass om dan daar weer op te kunnen vangen
        public delegate void AlarmEventHandler(AlarmEventArgs e);//om een custom EventArg mee te geven zoals nu de klok--standaard EventArg te gebruiken kan ook

        public Clock()
        {
            _alarms = new Dictionary<DateTime, bool>();
            _timer = new Timer(TimerTriggered, null, 0, 1000);//TimerCallback: Represents the method that handles calls from a System.Threading.Timer.
        }

        public void AddAlarm(DateTime alarm)
        {
            if (_alarms.ContainsKey(alarm))
            {
                _alarms[alarm] = false;
            }
            else
            {
                _alarms.Add(alarm, false);
            }
        }
        public void TimerTriggered(object s)
        {
            foreach (var alarm in _alarms)
            {
                if (alarm.Key <= DateTime.Now && alarm.Value == false)
                {
                    AlarmTriggered?.Invoke(new AlarmEventArgs(alarm.Key));
                    _alarms[alarm.Key] = true;
                }
            }
        }
    }
}
