using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_1
{
    public class Clock
    {
        private Timer _timer;
        private bool _alarmHasBeenTriggerd = false;
        public DateTime Alarm { get; set; }

        public event EventHandler AlarmTriggerd;

        public Clock(DateTime alarm)
        {
            _timer = new Timer(TimerTriggerd, null, 0, 1000);
            Alarm = alarm;
        }

        public void TimerTriggerd(object? state)
        {
            if (this.Alarm >= DateTime.Now && !_alarmHasBeenTriggerd)
            {
                AlarmTriggerd?.Invoke(this, null);
                _alarmHasBeenTriggerd =true;
            }
        }
    }
}
