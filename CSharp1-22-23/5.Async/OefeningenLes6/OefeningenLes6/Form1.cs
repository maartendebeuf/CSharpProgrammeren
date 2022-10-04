using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningenLes6
{
    public partial class Form1 : Form
    {
        private int _currentValue = 0;
        private int _calculatedValue = 0;

        delegate void SetProgressCallback(int value);

        public Form1()
        {
            InitializeComponent();

        }

        public void ReadTxt()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Maarten De Beuf\GitHub\MD_CSharpProgrammeren\CSharp1-22-23\5.Async\OefeningenLes6\Getallen.txt");
            SetPbarLength(lines.Length);
            //pbar1.Maximum = lines.Length;
            for (int i = 1; i < lines.Length; i++)
            {
                int getal = int.Parse(lines[i]);
                _currentValue = i;
                _calculatedValue += getal;
                //lblCalculatedValue1.Text = _calculatedValue.ToString(); 

                SetLblProgress(_calculatedValue);

                SetPbarProgress(_currentValue);
            }
        }

        private void SetPbarLength(int value)
        {
            if (this.pbar1.InvokeRequired)
            {
                SetProgressCallback setProgressCallback = new SetProgressCallback(SetPbarLength);
                this.Invoke(setProgressCallback, value);
            }
            else
            {
                this.pbar1.Maximum = value;
            }
        }

        private void SetPbarProgress(int value)
        {
            if (this.pbar1.InvokeRequired)
            {
                SetProgressCallback setProgressCallback = new SetProgressCallback(SetPbarProgress);
                this.Invoke(setProgressCallback, value);
            }
            else
            {
                this.pbar1.Value = value;
            }
        }
        private void SetLblProgress(int value)
        {
            if (this.pbar1.InvokeRequired)
            {
                SetProgressCallback setProgressCallback = new SetProgressCallback(SetLblProgress);
                this.Invoke(setProgressCallback, value);
            }
            else
            {
                this.lblCalculatedValue1.Text = value.ToString();
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            await Task.Run(ReadTxt);
        }

        private void btnDoeIets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goed gedaan!");
        }
    }
}
