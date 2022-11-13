using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoLijst
{
    public partial class TodoCreateView : Form
    {

        public delegate void TodoCreateEventHandler(string type, string name, string uitvoerder, DateTime dueDate, string description, string location);
        public event TodoCreateEventHandler TodoCreateEvent;
        public TodoCreateView()
        {
            InitializeComponent();
            coboxType.Items.Add("HomeWork");
            coboxType.Items.Add("OutsideWork");
            coboxType.SelectedIndex = 0;
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            CreateTodo();
        }
        private void btnAanmakenEnSluiten_Click(object sender, EventArgs e)
        {
            CreateTodo();
            this.Close();
        }
        private void CreateTodo()
        {
            TodoCreateEvent?.Invoke(coboxType.Text, tboxNaam.Text, tboxUitvoerder.Text, dtpUitvoerDatum.Value, rtboxOmschrijving.Text, tbLocatie.Text);
            coboxType.Text = "";
            tboxNaam.Text = "";
            tboxUitvoerder.Text = "";
            rtboxOmschrijving.Text = "";
            tbLocatie.Text = "";
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
