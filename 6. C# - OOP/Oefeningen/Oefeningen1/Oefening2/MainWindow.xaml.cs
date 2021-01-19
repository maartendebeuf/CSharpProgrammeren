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
    /// 
    //## Oefening 2 (WPF / Console)

    //Schrijf een applicatie die gebruik maakt van een methode die het aantal spaties telt in een string.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTelSpaties_Click(object sender, RoutedEventArgs e)
        {
            var tekst = tbxTekst.Text;
                        
            lblResultaat.Content = TelSpaties(tekst) + " spaties";
        }

        private int TelSpaties(string inpTekst)
        {
            char spatie = ' ';
            int aantalSpaties = 0;
            foreach (char letter in inpTekst)
            {
                if (letter == spatie)
                {
                    aantalSpaties++;
                }
            }
            lblResultaat.Content = aantalSpaties + " spaties";

            return aantalSpaties;
        }
    }
}
