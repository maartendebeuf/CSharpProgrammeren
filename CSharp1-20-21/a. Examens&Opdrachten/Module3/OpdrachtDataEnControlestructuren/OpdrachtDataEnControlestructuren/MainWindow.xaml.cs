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

        private double GeldigGetal(TextBox inpTextBox)
        {
            try
            {
                if (inpTextBox.Text != "")
                {
                    double invoer = double.Parse(inpTextBox.Text);
                    return invoer;
                }
                return 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Geen geldige invoer!");
                inpTextBox.Text = "";
                return 0;
            }
        }

        private void KeyEventReturn(KeyEventArgs inpE, TextBox inpTextBox)
        {
            if (inpE.Key == Key.Return)
            {
                inpTextBox.Focus();
            }
        }

        private void KeyEventReturn(KeyEventArgs inpE, Button inpButton)
        {
            if (inpE.Key == Key.Return)
            {
                inpButton.Focus();
            }
        }

        private void tbxTotaalprijs_TextChanged(object sender, TextChangedEventArgs e)
        {
            totaalprijs = GeldigGetal(tbxTotaalprijs);
        }

        private void tbxTotaalprijs_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventReturn(e, tbxAantal);
        }

        private void tbxAantal_TextChanged(object sender, TextChangedEventArgs e)
        {
            aantal = GeldigGetal(tbxAantal);
        }

        private void tbxAantal_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventReturn(e, tbxKleineKorting);
        }

        private void tbxKleineKorting_TextChanged(object sender, TextChangedEventArgs e)
        {
            kleineKorting = GeldigGetal(tbxKleineKorting);
        }

        private void tbxKleineKorting_KeyDown(object sender, KeyEventArgs e)
        {            
            KeyEventReturn(e, tbxGroteKorting);
        }

        private void tbxGroteKorting_TextChanged(object sender, TextChangedEventArgs e)
        {            
            groteKorting = GeldigGetal(tbxGroteKorting);
        }

        private void tbxGroteKorting_KeyDown(object sender, KeyEventArgs e)
        {            
            KeyEventReturn(e, btnBerekenKorting);
        }

        private void btnBerekenKorting_Click(object sender, RoutedEventArgs e)
        {
            BerekenKorting();                        
        }

        private void BerekenKorting()
        {
            if (totaalprijs > 0 && aantal > 0 && kleineKorting > 0 && groteKorting > 0)
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
            else
            {
                lblGekregenKorting.Content = "Gelieve overal een waarde boven nul in te voeren.";
            }
        }
    }
}
