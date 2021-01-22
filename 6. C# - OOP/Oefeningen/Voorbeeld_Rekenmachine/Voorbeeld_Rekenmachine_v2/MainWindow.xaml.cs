using System;
using System.Windows;
using System.Windows.Controls;

namespace Voorbeeld_Rekenmachine_v2
{
    public partial class MainWindow : Window
    {
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
            txtInput.Text = txtInput.Text + inputValue;
            rekenmachine.BewaarIngaveInGeschiedenis(txtInput.Text);
        }

        private void Bereken(string input)
        {
            try
            {
                rekenmachine.AnnuleerNavigatieDoorGeschiedenis();

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
            catch (Exception)
            {
                MessageBox.Show("Berekening bevat een fout. Probeer opnieuw.");
            }
        }

        private void TxtInput_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            try
            {
                if (e.Key == System.Windows.Input.Key.Up)
                {
                    var vorigeBerekening = rekenmachine.GetVorigeIngaveUitGeschiedenis();
                    txtInput.Clear();
                    SetInputText(vorigeBerekening);
                }
                else if (e.Key == System.Windows.Input.Key.Down)
                {
                    var volgendeBerekening = rekenmachine.GetVolgendeIngaveUitGeschiedenis();
                    txtInput.Clear();
                    SetInputText(volgendeBerekening);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Er liep iets fout.");
            }
        }

        private void OnClearAll(object sender, RoutedEventArgs e)
        {
            try
            {
                rekenmachine.WisAlleGeschiedenis();
                txtInput.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("De geschiedenis kon niet gewist worden.");
            }
        }

        private void OnClearLastEntry(object sender, RoutedEventArgs e)
        {
            try
            {
                rekenmachine.WisLaatsteIngave();
                // Een string is een lijst van characters
                // We kunnen dus de laatste ingave verwijderen door het laatste item uit die lijst te verwijderen
                var indexLaaststeIngave = txtInput.Text.Length - 1;
                if (indexLaaststeIngave >= 0)
                {
                    txtInput.Text = txtInput.Text.Remove(indexLaaststeIngave);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("De laatste ingave kon niet gewist worden.");
            }
        }
    }
}
