using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Deel1Methodes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Deel 1 Methodes
        //Maak in WPF een programma waarmee je een Belgisch ondernemingsnummer kan controleren.
        //Een Belgisch ondernemingsnummer is als volgt opgebouwd BE 0xxx.xxx.xxx waarbij BE de landcode is die standaard gevolgd wordt door een spatie en dan een 0.
        //Wanneer je de volgende 7 cijfers deelt door 97 in een gehele deling, 
        //dan is het getal gevormd door de laatste 2 cijfers gelijk aan 97 minus de rest van deze gehele deling.
        //Bij een geldig ondernemingsnummer verschijnt de tekst Geldig ondernemingsnummer, bij een ongeldig ondernemingsnummer Ongeldig ondernemingsnummer. 
        //Indien het ondernemingsnummer niet is ingegeven volgens de standaardopbouw vermeld in deze tekst, 
        //dan verschijnt de tekst Geef het ondernemingsnummer in volgens het juiste formaat.
        //Maak gebruik van methodes.
           
        public MainWindow()
        {            
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            UpdateResultaat();
        }

        private void UpdateResultaat()
        {
            string ondernemingsnummer = tbOndernemingsnummer.Text;
            bool geldigFormaat = ControleFormat(ondernemingsnummer);
            if (geldigFormaat)
            {
                bool geldigeNummer = ControleerNummer(ondernemingsnummer);
                if (geldigeNummer)
                {
                    lblResultaat.Content = "Geldig ondernemingsnummer";
                }
                else
                {
                    lblResultaat.Content = "Ongeldig ondernemingsnummer";
                }
            }
            else
            {
                lblResultaat.Content = "Geef het ondernemingsnummer in \nvolgens het juiste formaat";
            }
        }

        private bool ControleFormat(string ondernemingsnummer)
        {
            bool geldigeInput = false;

            var regex = new Regex(@"(?:^[B][E][ ][0]\d{3}[.]\d{3}[.]\d{3}$)");
            bool match = regex.IsMatch(ondernemingsnummer);
            if (match)
            {                
                geldigeInput = true;
            }
            return geldigeInput;
        }

        private bool ControleerNummer(string ondernemingsnummer)
        {
            int waarde1 = int.Parse(ondernemingsnummer.Substring(4, 3) + ondernemingsnummer.Substring(8, 3) + ondernemingsnummer.Substring(12, 1));
            int waarde2 = int.Parse(ondernemingsnummer.Substring(13, 2));            
            
            int restwaarde = waarde1 % 97;
            int uitkomst = 97 - restwaarde;

            bool geldigeInput = (waarde2 == uitkomst);

            return geldigeInput;
        }
                
    }
}
