using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Datum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnVandaag_Click(object sender, RoutedEventArgs e)
        {

            // eerst maken we een variabele aan waarin we de dag van 
            // vandaag opslaan. Daarna laten we de dag in het label 
            // lbloutput zien.

            DateTime vandaag = DateTime.Now;
            lblOutput.Content = vandaag.ToString();
        }

        private void btnJaar_Click(object sender, RoutedEventArgs e)
        {
            //een jaar is een getal , deze functie geeft dan ook een int terug 

            DateTime vandaag = DateTime.Now;
            int jaar = vandaag.Year;
            lblOutput.Content = jaar.ToString();
        }

        private void btnWeekdag_Click(object sender, RoutedEventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            var dag = vandaag.DayOfWeek;
            lblOutput.Content = dag;
        }

        private void btnNummer_Click(object sender, RoutedEventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            int maand = vandaag.Month;
            lblOutput.Content = maand.ToString();
        }

        private void btnNaam_Click(object sender, RoutedEventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            var maand = vandaag.ToString("MMMM");
            lblOutput.Content = maand;
        }

        private void btnAfkorting_Click(object sender, RoutedEventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            var maand = vandaag.ToString("MMM");
            lblOutput.Content = maand;
        }

        private void btnLeeftijd_Click(object sender, RoutedEventArgs e)
        {
            DateTime geboortedatum = (DateTime)dateTimePickerGeboortedatum.SelectedDate;
            DateTime vandaag = DateTime.Now;
            TimeSpan leeftijd = vandaag - geboortedatum;
            lblOutput.Content = (leeftijd.TotalDays / 356.25);

        }
    }    
}
