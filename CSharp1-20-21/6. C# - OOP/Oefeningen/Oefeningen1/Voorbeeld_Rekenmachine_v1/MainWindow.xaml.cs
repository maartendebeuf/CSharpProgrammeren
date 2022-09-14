using System.Windows;
using System.Windows.Controls;

namespace Voorbeeld_Rekenmachine_v1
{
    public partial class MainWindow : Window
    {
        //## Uitbreiding Rekenmachine

        //Voorzie nog een aantal bewerkingen:

        //* Exponentieel(2 ^ 3 = 8) (TIP: ^ in C# berekend de exponent niet van twee getallen)
        //* Modulo(10 % 3 = 1)

        //Implementeer geschiedenis van de gemaakte bewerkingen.Zorg ervoor dat je via de pijltjestoetsen kan navigeren.
        //Implementeer ook het wissen van de laatste input en de volledige geschiedenis (CE / C).\
        //Als laatste moeten fouten correct getoond worden.

        private Rekenmachine rekenmachine;

        public MainWindow()
        {
            InitializeComponent();
            // Aanmaken instantie Calculator tijdens creatie MainWindow
            rekenmachine = new Rekenmachine();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            // Verwijder alle tekst uit het tekstveld wanneer we 
            // met de vorige berekening een resultaat berekend hebben
            if (rekenmachine.IsResultaatBerekend())
            {
                txtInput.Clear();
            }

            var knop = (Button)sender;
            var input = knop.Content.ToString();
            Bereken(input);
        }

        /// <summary>
        /// Toon de berekening in het tekstveld
        /// </summary>
        /// <param name="inputValue"></param>
        private void SetInputText(string inputValue)
        {
            //  txtInput.Text += inputValue;
            txtInput.Text = txtInput.Text + inputValue;
        }

        private void Bereken(string input)
        {
            // Toon tekst - berekening
            SetInputText(input);
            
            // Controleer met welke tekst we te maken hebben
            //  1. Bewerking?
            //  2. Getal?
            //  3. Gelijkaan teken? => Uitrekenen
            if (rekenmachine.IsGeldigeBewerking(input))
            {
                rekenmachine.BewaarBewerking(input);
            }
            else if (double.TryParse(input, out var getal))
            {
                rekenmachine.BewaarGetal(getal);
            }
            else if (input == "=")
            {
                var resultaat = rekenmachine.BerekenResultaat();
                SetInputText(resultaat.ToString());
            }
        }
    }
}
