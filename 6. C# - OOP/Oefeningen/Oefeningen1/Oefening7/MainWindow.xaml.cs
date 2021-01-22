using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oefening7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //## Oefening 7 (WPF)

    //Maak een WPF-applicatie die een lijst van auto's aanmaakt. 
    //Zorg voor knoppen die methodes aanroept om de auto te laten starten, rijden, draaien (links en rechts). 
    //Iedere auto heeft ook een naam. Toon voor iedere actie een tekst die de actie beschrijft (vb. Auto X start).

    public partial class MainWindow : Window
    {
        List<Auto> autolijst = new List<Auto>();
        int autokeuze = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNieuweAuto_Click(object sender, RoutedEventArgs e)
        {
            Auto auto = new Auto();
            string nieuweAuto = tbxNieuweAuto.Text;
            auto.Nieuw(nieuweAuto);
            autolijst.Add(auto);

            lbAuto.Items.Add(nieuweAuto);
            autokeuze = autolijst.Count - 1;
        }                

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (autolijst.Count>0)
            {
                autolijst[autokeuze].Start();
            }
            else
            {
                MessageBox.Show("Maak eerst een auto aan.");
            }
        }
        private void btnVooruit_Click(object sender, RoutedEventArgs e)
        {
            if (autolijst.Count > 0 && autolijst[autokeuze].Gestart())
            {
                autolijst[autokeuze].Vooruit();
            }
            else
            {
                MessageBox.Show("Start een auto.");
            }
        }

        private void btnLinks_Click(object sender, RoutedEventArgs e)
        {
            if (autolijst.Count > 0 && autolijst[autokeuze].Gestart())
            {
                autolijst[autokeuze].Links();
            }
            else
            {
                MessageBox.Show("Start een auto.");
            }
        }

        private void btnRechts_Click(object sender, RoutedEventArgs e)
        {
            if (autolijst.Count > 0 && autolijst[autokeuze].Gestart())
            {
                autolijst[autokeuze].Rechts();
            }
            else
            {
                MessageBox.Show("Start een auto.");
            }
        }

        private void lbAuto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (autolijst.Count > 0 && autolijst[autokeuze].Gestart())
            {
                autokeuze = lbAuto.SelectedIndex;
            }            
        }
    }
}
