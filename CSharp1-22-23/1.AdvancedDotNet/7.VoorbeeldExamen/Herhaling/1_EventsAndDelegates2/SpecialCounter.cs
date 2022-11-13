using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EventsAndDelegates2
{
    public delegate void DivisableEventHandler(object? sender, DivisableEventArgs e);

    public class SpecialCounter
    {
        private int counter;

        public event DivisableEventHandler DivisableBy5;

        public SpecialCounter()
        {
        }

        public void Add()
        {
            counter++;
            if (counter % 5 == 0)
            {
                DivisableBy5?.Invoke(this, new DivisableEventArgs(counter));
            }
        }
    }
}
