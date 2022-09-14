using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_2
{
    internal class BucketEventArgs : EventArgs
    {
        public int Counter { get; set; }

        public BucketEventArgs(int counter)
        {
            Counter = counter;
        }
    }
}
