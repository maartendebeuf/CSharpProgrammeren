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

namespace Oefening4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //## Oefening 4 (WPF)

    //Doe hetzelfde voor de omtrek van een rechthoek. Je hoeft de gebruiker geen nieuwe gegevens te vragen. 
    //Gebruik `Labels` om duidelijk aan te geven wat je getallen betekenen.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }               

        private void btnOppervlakte_Click(object sender, RoutedEventArgs e)
        {
            if (tbxLengte.Text != "" && tbxBreedte.Text != "")
            {
                try
                {
                    double lengte = double.Parse(tbxLengte.Text);
                    double breedte = double.Parse(tbxBreedte.Text);

                    lblOppervlakteResultaat.Content = Oppervlakte(lengte, breedte);
                }
                catch (Exception)
                {
                    MessageBox.Show("Geen geldige waardes");
                }
            }
        }
        private double Oppervlakte(double inpLengte, double inpBreedte)
        {
            double oppervlakte = inpLengte * inpBreedte;

            return oppervlakte;
        }

        private void btnOmtrek_Click(object sender, RoutedEventArgs e)
        {
            if (tbxLengte.Text != "" && tbxBreedte.Text != "")
            {
                try
                {
                    double lengte = double.Parse(tbxLengte.Text);
                    double breedte = double.Parse(tbxBreedte.Text);

                    lblOmtrekResultaat.Content = Omtrek(lengte, breedte);
                }
                catch (Exception)
                {
                    MessageBox.Show("Geen geldige waardes");
                }
            }
        }
        private double Omtrek(double inpLengte, double inpBreedte)
        {
            double omtrek = (inpLengte + inpBreedte)*2;

            return omtrek;
        }
    }
}
