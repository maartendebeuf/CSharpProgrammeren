using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1
{
    public partial class Form1 : Form
    {

        Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "x";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Color randomColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));

            button.BackColor = randomColor;
        }
    }
}
