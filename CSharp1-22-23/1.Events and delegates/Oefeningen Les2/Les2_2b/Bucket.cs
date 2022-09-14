using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_2b
{
    internal class Bucket
    {
        public int MaxAmount { get; set; } = 100;
        private bool isFull = false;
        public int CurrentAmount { get; set; } = 0;
        private bool isAlmostFull = false;
        public void Fill(int amount)
        {
            if (!isFull)
            {
                CurrentAmount += amount;
            }
            IsBucketFull();
        }

        public event EventHandler BucketIsAlmostFull;

        public event EventHandler BucketIsFull;

        private void IsBucketFull()
        {
            
            if (this.CurrentAmount >= this.MaxAmount && !isFull)
            {
                BucketIsFull?.Invoke(this, null);
                isFull = true;
                //lblMessage.Text = "Bucket is full";
            }
            else if (this.CurrentAmount >= (this.MaxAmount / 10 * 8) && !isAlmostFull)
            {
                BucketIsAlmostFull?.Invoke(this, null);
                isAlmostFull = true;
                //lblMessage.Text = "Bucket is almost full";
            }
        }
    }
}
