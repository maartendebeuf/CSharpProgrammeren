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

namespace Oefening1_uitbreinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bestelling> bestellingen = new List<Bestelling>();

        Bestelling nieuweBestelling;

        bool ArtikelNaamIngevuld;
        bool EenheidsprijsIngevuld;
        bool AantalArtikelenIngevuld;

        public MainWindow()
        {
            InitializeComponent();
            nieuweBestelling = new Bestelling();
            dbBestellingen.ItemsSource = bestellingen;
        }

        private void tbxArtikelNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxArtikelNaam.Text != "")
            {
                ArtikelNaamIngevuld = true;
                nieuweBestelling.ArtikelNaam = tbxArtikelNaam.Text;
                Berekening();
            }
        }

        private void tbxEenheidsprijs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxEenheidsprijs.Text != "")
            {
                EenheidsprijsIngevuld = true;
                try
                {
                    nieuweBestelling.Eenheidsprijs = int.Parse(tbxEenheidsprijs.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("geen geldige invoer");
                    tbxEenheidsprijs.Text = "";
                }
                Berekening();
            }
        }

        private void tbxAantalArtikelen_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxAantalArtikelen.Text != "")
            {
                AantalArtikelenIngevuld = true;
                try
                {
                    nieuweBestelling.AantalArtikelen = int.Parse(tbxAantalArtikelen.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("geen geldige invoer");
                    tbxAantalArtikelen.Text = "";
                }
                Berekening();
            }
        }

        public void Berekening()
        {
            if (ArtikelNaamIngevuld && EenheidsprijsIngevuld && AantalArtikelenIngevuld)
            {
                string ArtikelNaam = nieuweBestelling.ArtikelNaam;
                int Eenheidsprijs = nieuweBestelling.Eenheidsprijs;
                int AantalArtikelen = nieuweBestelling.AantalArtikelen;
                int Totaalprijs = nieuweBestelling.Totaalprijs;
                lblTotaalprijsResultaat.Content = $"{ArtikelNaam}, {Eenheidsprijs}euro/stuk, {AantalArtikelen}stuks. Totaal = {Totaalprijs}euro";
            }
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            bestellingen.Add(nieuweBestelling);
            dbBestellingen_Update();
            tbxArtikelNaam.Text = "";
            tbxAantalArtikelen.Text = "";
            tbxEenheidsprijs.Text = "";
            nieuweBestelling = new Bestelling();
        }

        private void dbBestellingen_Update()
        {
            dbBestellingen.Items.Refresh();
        }
    }
}
