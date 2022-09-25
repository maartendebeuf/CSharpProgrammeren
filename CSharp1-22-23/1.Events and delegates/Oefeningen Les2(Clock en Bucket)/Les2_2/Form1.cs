using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les2_2
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

        private void _bucket_BucketIsAlmostFull(object sender, BucketEventArgs e)
        {
            //lblMessage.Text = "Bucket is almost full";
            this.BackColor = Color.Red;

            //if (_bucket.CurrentAmount > (_bucket.MaxAmount / 10 * 8))
            //{
            //}
        }

        private void _bucket_BucketIsFull(object sender, BucketEventArgs e)
        {
            lblMessage.Text = "Bucket is full";
            btnAdd.Enabled = false;
            btnReset.Visible = true;
        }


        private void btnReset_MouseClick(object sender, MouseEventArgs e)
        {
            _bucket.Clear();
            btnAdd.Enabled = true;
            this.BackColor = Color.Empty;
            lblAmount.Text = "";
            lblMessage.Text = "";
            btnReset.Visible=false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _bucket.Fill(10);
            lblAmount.Text = _bucket.CurrentAmount.ToString();

        }
    }
}
