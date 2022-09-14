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

namespace Oefening1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //## Oefening 1

    //Ontwerp een applicatie om een bestelling te verwerken.\
    //Te bewaren in een object:
    //* Naam besteld artikel
    //* Eenheidsprijs artikel
    //* Aantal bestelde artikelen
    //* Totaalprijs bestelling
    

    //    Werk met methodes en/of properties. Toon als laatste een overzicht van de bestelling (product, aantal, eenheidsprijs en totaalprijs).

    //** Uitbreiding**: Voorzie dat je een lijst met bestellingen kan toevoegen, opslaan en weergeven.

    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
        }
        bool ArtikelNaamIngevuld;
        bool EenheidsprijsIngevuld;
        bool AantalArtikelenIngevuld;

        Bestelling nieuweBestelling = new Bestelling();

        private void tbxArtikelNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbxArtikelNaam.Text != "")
            {
                ArtikelNaamIngevuld=true;
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
            if(ArtikelNaamIngevuld && EenheidsprijsIngevuld && AantalArtikelenIngevuld)
            {
                string ArtikelNaam = nieuweBestelling.ArtikelNaam;
                int Eenheidsprijs = nieuweBestelling.Eenheidsprijs;
                int AantalArtikelen = nieuweBestelling.AantalArtikelen;
                int Totaalprijs = nieuweBestelling.GetTotaalprijs();
                lblTotaalprijsResultaat.Content = $"{ArtikelNaam}, {Eenheidsprijs}euro/stuk, {AantalArtikelen}stuks.\nTotaal = {Totaalprijs}euro";
            }
        }
    }
}
