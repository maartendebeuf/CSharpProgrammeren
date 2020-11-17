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

namespace Oefening5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Maak een programma met een grote multiLine `TextBox`. Je kan hier een willekeurige tekst invoeren.\
            //Plaats daarnaast een invoervak waarin de gebruiker maximaal **1 teken** mag invoeren.

            //1.Zorg voor een knop die weergeeft hoeveel keer het ingevoerde teken voorkomt in de ingevoerde tekst.
            //2.Zorg voor een knop die het aantal klinkers telt.
            //3.Zorg voor een knop die het aantal spaties telt.
            //4.Zorg voor een knop die het aantal medeklinkers telt.

            //Zorg voor een correcte foutafhandeling.
            InitializeComponent();
        }

        private void btnAantal_Click(object sender, RoutedEventArgs e)
        {
            var Invoer = tbInvoervak.Text;
            var letter = tbLetter.Text;
            int aantal = 0;
            foreach(char teken in Invoer)
            {
                if(teken == char.Parse(letter))
                {
                    aantal++;
                }
            }
            tbAantal.Text = aantal.ToString();
        }

        private void btnKlinkers_Click(object sender, RoutedEventArgs e)
        {
            var Invoer = tbInvoervak.Text;
            int aantal = 0;
            foreach (char teken in Invoer)
            {
                if (teken == 'a' 
                    || teken == 'e' 
                    || teken == 'i' 
                    || teken == 'o' 
                    || teken == 'u')
                {
                    aantal++;
                }
            }
            tbAantal.Text = aantal.ToString();
        }

        private void btnSpaties_Click(object sender, RoutedEventArgs e)
        {
            var Invoer = tbInvoervak.Text;
            int aantal = 0;
            foreach (char teken in Invoer)
            {
                if (teken == ' ')
                {
                    aantal++;
                }
            }
            tbAantal.Text = aantal.ToString();
        }

        private void btnMedeklinkers_Click(object sender, RoutedEventArgs e)
        {
            var Invoer = tbInvoervak.Text;
            int aantal = 0;
            foreach (char teken in Invoer)
            {
                if (teken != 'a'
                    && teken != 'e'
                    && teken != 'i'
                    && teken != 'o'
                    && teken != 'u')
                {
                    aantal++;
                }
            }
            tbAantal.Text = aantal.ToString();
        }

    }
}
