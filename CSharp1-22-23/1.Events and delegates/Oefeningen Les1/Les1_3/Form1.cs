using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1_3
{
    public partial class Form1 : Form
    {

        bool _isStarted = false;
        Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isStarted)
            {
                int r;
                if (checkBoxR.Checked) r = _random.Next(256);
                else r = 0;
                int g;
                if (checkBoxG.Checked) g = _random.Next(256);
                else g = 0;
                int b;
                if (checkBoxB.Checked) b = _random.Next(256);
                else b = 0;



                Color randomColor = Color.FromArgb(r,g,b);

                this.BackColor = randomColor;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            timer1.Interval = 100*(-trackBar.Value);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _isStarted = true;
           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _isStarted =false;
            this.BackColor = Color.Empty;
        }
    }
}
