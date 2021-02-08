using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oefening2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dgLeerlingen.ItemsSource = leerlingen;
        }
        string voornaam;
        string naam;
        string klas;
        List<Leerling> leerlingen = new List<Leerling>();

        private void tbxVoornaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxVoornaam.Text!="")
            {
                voornaam = tbxVoornaam.Text;
            }
        }

        private void tbxNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxNaam.Text != "")
            {
                naam = tbxNaam.Text;
            }
        }

        private void tbxKlas_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxKlas.Text != "")
            {
                klas = tbxKlas.Text;
            }
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(voornaam) && !string.IsNullOrEmpty(naam) && !string.IsNullOrEmpty(klas))
            {
                Leerling leerling = new Leerling(voornaam, naam, klas);
                leerlingen.Add(leerling);
                dgLeerling_Update();
            }
        }

        private void dgLeerling_Update()
        {
            dgLeerlingen.Items.Refresh();
        }

        private void dgLeerlingen_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            dgLeerlingen.Items.c
        }
    }
}
