using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2_2b
{
    public partial class Form1 : Form
    {
        Bucket _bucket;
        public Form1()
        {

            _bucket = new Bucket();
            _bucket.BucketIsFull += _bucket_BucketIsFull;
            _bucket.BucketIsAlmostFull += _bucket_BucketIsAlmostFull;

            InitializeComponent();
        }

        private void _bucket_BucketIsAlmostFull(object sender, EventArgs e)
        {
            //lblMessage.Text = "Bucket is almost full";
            this.BackColor = Color.Red;

            //if (_bucket.CurrentAmount > (_bucket.MaxAmount / 10 * 8))
            //{
            //}
        }

        private void _bucket_BucketIsFull(object sender, EventArgs e)
        {
            lblMessage.Text = "Bucket is full";
            //if (_bucket.CurrentAmount > _bucket.MaxAmount)
            //{
                
            //}
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            _bucket.Fill(10);
            lblAmount.Text = _bucket.CurrentAmount.ToString();
        }
    }
}
