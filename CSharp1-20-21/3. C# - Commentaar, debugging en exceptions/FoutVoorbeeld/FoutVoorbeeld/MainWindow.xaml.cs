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

namespace FoutVoorbeeld
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

        private void btnBreuk_Click(object sender, RoutedEventArgs e)
        {
            //initialisatie van de variabelen
            double getal = 0;
            double breuk = 0;
            if (string.IsNullOrEmpty(txbGetal.Text))
            {
                throw new ApplicationException("verplicht veld!");
            }
            //toekenning van waarden / berekening
            try
            {
                getal = Double.Parse(txbGetal.Text);
                breuk = 1 / getal;
            }
            catch (Exception exeption)
            {

                MessageBox.Show("Er is een fout opgetreden! " + exeption.Message);
            }


            
            //tonen van de uitkomst
            MessageBox.Show("de breuk van " + getal.ToString() + " is: " + breuk.ToString());
        }
    }
}
