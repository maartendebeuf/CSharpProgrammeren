using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpOverViewWPF._3.AdvancedDotNet.Async
{
    public partial class Form1 : Form
    {
        private int _maxValue = 10000000;

        public Form1()
        {
            InitializeComponent();
            //instellen maximum waarde progress bar
            pbarProgress.Maximum = _maxValue;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Aanpassen van de progress bar tot wanneer we het maximum bereiken
            for (int i = 1; i <= _maxValue; i++)
            {
                pbarProgress.Value = i;
            }

            //Na het klikken op de starten, wordt heel het formulier niet meer responsief.
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Huidige waarde: " + pbarProgress.Value.ToString());
        }
    }
}
