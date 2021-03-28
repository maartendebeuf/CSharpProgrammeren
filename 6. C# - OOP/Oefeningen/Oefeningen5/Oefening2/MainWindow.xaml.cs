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
    //## Oefening 2

    //Maak een hiërarchie van dieren. De taak is eenvoudig: er zou een basisklasse moeten zijn waar alle andere van afgeleid zijn.
    //Het programma moet drie verschillende dieren bevatten: hond, kikker en kat.
    //Laten we dieper in de hiërarchie gaan en twee extra klassen maken: 
    //Kitten en Tomcat. Kittens zijn vrouwtjes en Tomcats zijn mannetjes! 
    //Daarnaast maken alle dieren natuurlijk geluid. Voorzie iets zodat ieder dier zijn eigen geluid maakt. De hond moet bijvoorbeeld blaffen.

    //Het is jouw taak om de hiërarchie te modelleren en de functionaliteit ervan te testen. Creëer allerlei soorten dieren en laat ze geluid produceren (in tekst).

    //### Input
    //(ofwel console, ofwel via wpf textbox)
    //* het type (kat, hond, ...)
    //* de naam
    //* de leeftijd
    //* het geslacht
  
    //Indien dit als console applicatie gemaakt wordt stop je het vragen van gegevens wanneer het commando 'beest!' gegeven wordt.

    //### Output
    //* Het type dier
    //* De naam, leeftijd en het geslacht
    //* Het geluid van het dier

    //### Voorwaarden
    //* Iedere dier heeft een naam, leeftijd en geslacht
    //* Alle properties moeten ingevuld zijn. Lege waardes zijn niet toegestaan
    //* Bij ongeldige ingave geef je correcte foutboodschappen
    //* Ieder dier maakt geluid

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hond hond = new Hond("Zita", 2, "mannetje");
            hond.PrintGeluid();
            Kikker kikker = new Kikker("Kermit", 3, "vrouwtje");
            kikker.PrintGeluid();
            Kitten kitten = new Kitten("Felix", 3);
            kitten.PrintGeluid();
            Tomcat tomcat = new Tomcat("Simba", 3);
            tomcat.PrintGeluid();

        }

        private void tbxLeeftijd_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string tekst = textbox.Text;
            string tekstInput = e.Text;
            string volledigeTekst = tekst + tekstInput

        }
    }
}
