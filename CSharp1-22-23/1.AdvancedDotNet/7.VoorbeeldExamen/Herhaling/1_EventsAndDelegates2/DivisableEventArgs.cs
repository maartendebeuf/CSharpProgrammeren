using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EventsAndDelegates2
{
    public class DivisableEventArgs: EventArgs
    {
        public int Counter { get; set; }

        public DivisableEventArgs(int counter)
        {
            Counter = counter;
        }
    }
}
