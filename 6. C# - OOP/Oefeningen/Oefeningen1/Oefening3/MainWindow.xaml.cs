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

namespace Oefening3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //## Oefening 3 (WPF)

    //Maak een methode die de oppervlakte van een rechthoek uitrekent.\
    //Met de *lengte* en *breedte* wordt de *oppervlakte* uitgerekend.\
    //Er moeten dus twee invoervelden komen waar de gebruiker beide gegevens kan invoeren. 
    //Voeg aan het programma een knop toe om de *oppervlakte* uit te rekenen en op het scherm te plaatsen.

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
    }
}
