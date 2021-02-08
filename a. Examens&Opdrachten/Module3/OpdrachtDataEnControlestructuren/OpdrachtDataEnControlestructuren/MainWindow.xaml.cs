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

namespace OpdrachtDataEnControlestructuren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //Maak een applicatie(console of WPF) die al dan niet korting toekent.Maak gebruik van methodes.
    //Invoerveld: Totale prijs
    //Invoerveld: Aantal artikelen
    //Zorg ervoor dat het duidelijk is wat je aan het ingeven bent.


    //Indien het aantal artikelen hoger ligt dan 2, dan wordt 25% korting toegestaan.
    //Afhankelijk van het aantal artikelen wordt volgende tekst getoond:
    //U heeft geen korting
    //U krijgt 25% korting


    public partial class MainWindow : Window
    {
        double totaalprijs;
        double aantal;
        double kleineKorting;
        double groteKorting;

        public MainWindow()
        {
            InitializeComponent();
            tbxTotaalprijs.Focus();
        }

        private bool GeldigGetal(string inpGetal)
        {
            try
            {
                if (inpGetal != "" )
                {
                    double invoer = double.Parse(inpGetal);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Geen geldige invoer!");
                return false;
            }
        }

        private void tbxTotaalprijs_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool geldigGetal = GeldigGetal(tbxTotaalprijs.Text);
            if (geldigGetal)
            {
                double invoer = double.Parse(tbxTotaalprijs.Text);
                totaalprijs = invoer;
            }
            else
            {
                tbxTotaalprijs.Text = "";
            }            
        }

        private void tbxTotaalprijs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                tbxAantal.Focus();
            }
        }

        private void tbxAantal_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool geldigGetal = GeldigGetal(tbxAantal.Text);
            if (geldigGetal)
            {
                double invoer = double.Parse(tbxAantal.Text);
                aantal = invoer;
            }
            else
            {
                tbxAantal.Text = "";
            }            
        }

        private void tbxAantal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                tbxKleineKorting.Focus();
            }            
        }

        private void tbxKleineKorting_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool geldigGetal = GeldigGetal(tbxKleineKorting.Text);
            if (geldigGetal)
            {
                double invoer = double.Parse(tbxKleineKorting.Text);
                kleineKorting = invoer;
            }
            else
            {
                tbxKleineKorting.Text = "";
            }            
        }

        private void tbxKleineKorting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                tbxGroteKorting.Focus();
            }
        }

        private void tbxGroteKorting_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool geldigGetal = GeldigGetal(tbxGroteKorting.Text);
            if (geldigGetal)
            {
                double invoer = double.Parse(tbxGroteKorting.Text);
                groteKorting = invoer;
            }
            else
            {
                tbxGroteKorting.Text = "";
            }            
        }

        private void tbxGroteKorting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                btnBerekenKorting.Focus();
            }
        }

        private void btnBerekenKorting_Click(object sender, RoutedEventArgs e)
        {
            BerekenKorting();                        
        }

        private void BerekenKorting()
        {
            if (totaalprijs != 0 && aantal != 0&& kleineKorting != 0 && groteKorting != 0)
            {
                if (aantal > 5)
                {
                    double korting = totaalprijs / 100 * groteKorting;
                    lblGekregenKorting.Content = $"U krijgt {groteKorting}% korting!\nU hebt {korting}€ korting gekregen en \nmoet nog {totaalprijs - korting}€ betalen.";
                }
                
                else if (aantal > 2)
                {
                    double korting = totaalprijs / 100 * kleineKorting;
                    lblGekregenKorting.Content = $"U krijgt {kleineKorting}% korting!\nU hebt {korting}€ korting gekregen en \nmoet nog {totaalprijs - korting}€ betalen.";
                }                
                else
                {
                    lblGekregenKorting.Content = "U heeft geen korting";
                }
            }         
        }
    }
}
