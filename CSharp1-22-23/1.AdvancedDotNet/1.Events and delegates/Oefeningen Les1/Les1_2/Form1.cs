using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1_2
{
    public partial class Form1 : Form
    {
        string _xOrO = "X";
        private string XOrO
        {
            get
            {
                if (_xOrO.Equals("X"))
                {
                    _xOrO = "O";
                    return _xOrO;
                }
                else
                {
                    _xOrO = "X";
                    return _xOrO;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = XOrO;
            button.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    Button button = (Button)item;
                    if (!button.Name.Equals("buttonRestart"))
                    {
                        button.Text = "";
                        button.Enabled = true;
                    }
                }
            }
            _xOrO = "X";
        }
    }
}
