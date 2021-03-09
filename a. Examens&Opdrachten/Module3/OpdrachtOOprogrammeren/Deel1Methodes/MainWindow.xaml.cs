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

        public string Resultaat { get; private set; }
        string testwaarde = "BE 0xxx.xxx.xxx";

        public MainWindow()
        {
            Resultaat = "";
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            string ondernemingsnummer = tbOndernemingsnummer.Text;
            bool geldigeInput = ControleFormat(ondernemingsnummer);
            if (geldigeInput)
            {
                ControleerNummer(ondernemingsnummer);
            }
            else
            {
                lblResultaat.Content = "Geef het ondernemingsnummer in volgens het juiste formaat";
            }            
        }

        private void ControleerNummer(string ondernemingsnummer)
        {

        }

        private bool ControleFormat(string ondernemingsnummer)
        {
            bool geldigeInput = false;
            if (ondernemingsnummer.Length == 15)
            {
                string landcode = ondernemingsnummer.Substring(0, 4);

            }
            return geldigeInput;
        }

        private void tbOndernemingsnummer_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ondernemingsnummer = tbOndernemingsnummer.Text;
            if (ondernemingsnummer.Length != 7)
            {
                Resultaat = "";
            }            
        }
    }
}
