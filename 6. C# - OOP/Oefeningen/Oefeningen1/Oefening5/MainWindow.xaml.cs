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

    //## Oefening 5 (WPF / Console)

    //Schrijf een methode waarmee je de omtrek en de  oppervlakte van een cirkel kan berekenen met een ingegeven straal. 
    //Rond de resultaten af tot op 2 cijfers na de komma.

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOppervlakte_Click(object sender, RoutedEventArgs e)
        {
            if (tbxStraal.Text != "" )
            {
                try
                {
                    double straal = double.Parse(tbxStraal.Text);                

                    lblOppervlakteResultaat.Content = OppervlakteCirkel(straal);
                }
                catch (Exception)
                {
                    MessageBox.Show("Geen geldige waardes");
                }
            }

        }
        private double OppervlakteCirkel(double straal)
        {

            double oppervlakte = (straal*straal)*Math.PI;

            return oppervlakte;
        }

        private void btnOmtrek_Click(object sender, RoutedEventArgs e)
        {
            if (tbxStraal.Text != "")
            {
                try
                {
                    double straal = double.Parse(tbxStraal.Text);

                    lblOmtrekResultaat.Content = OmtrekCirkel(straal);
                }
                catch (Exception)
                {
                    MessageBox.Show("Geen geldige waardes");
                }
            }
        }
        private double OmtrekCirkel(double straal)
        {

            double oppervlakte = (straal + straal) * Math.PI;

            return oppervlakte;
        }
    }
}
