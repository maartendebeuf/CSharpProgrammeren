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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbxTotaalprijs_GotMouseCapture(object sender, MouseEventArgs e)
        {
            tbxTotaalprijs.Text = "";
            tbxTotaalprijs.Foreground = Brushes.Black;
        }      

        private void tbxAantal_GotMouseCapture(object sender, MouseEventArgs e)
        {
            tbxAantal.Text = "";
            tbxAantal.Foreground = Brushes.Black;
        }

        private void btnBerekenKorting_Click(object sender, RoutedEventArgs e)
        {
            BerekenKorting();
        }

        private void BerekenKorting()
        {
            double Totale;
        }
    }
}
