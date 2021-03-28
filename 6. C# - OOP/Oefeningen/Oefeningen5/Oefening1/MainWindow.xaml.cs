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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //## Oefening 2

        //Maak onderstaande oefening in WPF.
        //Zorg ervoor dat we een ongelimiteerd aantal werknemers kunnen aanmaken. Voorzie dus een lijst van werknemers.\
        //In een bedrijf werken drie soorten werknemers: arbeiders, bedienden en kaderleden. Ontwerp voor ieder een aparte klasse.\
        //Alle **werknemers** hebben een voornaam en een naam.\
        //**Arbeiders** ontvangen een uurloon daarom is het belangrijk om voor iedere arbeider bij te houden het aantal gewerkte uren in 
        //de afgelopen maand.\
        //**Bedienden** en **kaderleden** krijgen een maandwedde uitbetaald en ontvangen maaltijdcheques. Het aantal maaltijdcheques komt overeen met het aantal gewerkte dagen.\
        //**Kaderleden** hebben recht op een bedrijfswagen. Van de kaderleden wordt bijgehouden welk type auto ze hebben.\
        //Maak gebruik van overerving bij het oplossen van deze oefening.
        public List<Werknemer> Werknemers { get; set; } = new List<Werknemer>();

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
             
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbxVoornaam.Text)|| !string.IsNullOrWhiteSpace(tbxNaam.Text))
                {
                    if ((bool)rbArbeider.IsChecked)
                    {
                        ArbeiderToevoegen();
                    }
                    else if ((bool)rbBediende.IsChecked)
                    {
                        BediendeToevoegen();
                    }
                    else if ((bool)rbKaderlid.IsChecked)
                    {
                        if (!string.IsNullOrWhiteSpace(tbxBedrijfswagen.Text))
                        {
                            KaderlidToevoegen();
                        }               
                    } 
                    else
                    {
                        Foutmelding();
                    }    
                }
                else
                {
                    Foutmelding();
                }
                dgWerknemers.Items.Refresh();
            }
            catch (Exception)
            {

                throw;
            }   
        }
        private void dgWerknemers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WerknemerInfo();
        }
        private void btnPrestatieToevoegen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int aantal = int.Parse(tbxPrestatieToevoegen.Text);
                PrestatieToevoegen(aantal);
            }
            catch (Exception)
            {
                Foutmelding();
            }
            tbxPrestatieToevoegen.Text = "";
        }

        private void ArbeiderToevoegen()
        {
            string voornaam = tbxVoornaam.Text;
            string naam = tbxNaam.Text;
                       
            Arbeider arbeider = new Arbeider(voornaam, naam);
            arbeider.GepresteerdeUrenMaand = 0;
            WerknemerToevoegen(arbeider);
        }
        private void BediendeToevoegen()
        {
            string voornaam = tbxVoornaam.Text;
            string naam = tbxNaam.Text;

            Bediende bediende = new Bediende(voornaam, naam);
            bediende.GepresteerdeDagenMaand = 0;
            WerknemerToevoegen(bediende);
        }
        private void KaderlidToevoegen()
        {
            string voornaam = tbxVoornaam.Text;
            string naam = tbxNaam.Text;
            string bedrijfswagen = tbxBedrijfswagen.Text;
            Kaderlid kaderlid = new Kaderlid(voornaam, naam, bedrijfswagen);
            kaderlid.GepresteerdeDagenMaand = 0;
            WerknemerToevoegen(kaderlid);
        }
        private void WerknemerToevoegen(Werknemer werknemer)
        {
            Werknemers.Add(werknemer);
            int aantal = Werknemers.Count() - 1;
            dgWerknemers.SelectedIndex = aantal;
        }
        private void WerknemerInfo()
        {
            Werknemer werknemer = Werknemers[dgWerknemers.SelectedIndex];
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Voornaam: " + werknemer.Voornaam);
            stringBuilder.AppendLine("Naam: " + werknemer.Naam);
            try
            {
                Arbeider arbeider = (Arbeider)werknemer;
                stringBuilder.AppendLine("Prestaties: " + arbeider.GepresteerdeUrenMaand);

                lblTypeLoon.Content = "uren";

                tbxVoornaam.Text = arbeider.Voornaam;
                tbxNaam.Text = arbeider.Naam;
                tbxBedrijfswagen.Text = "";
                rbArbeider.IsChecked = true;
            }
            catch (Exception)
            {

            }
            try
            {
                Bediende bediende = (Bediende)werknemer;                
                stringBuilder.AppendLine("Prestaties: " + bediende.GepresteerdeDagenMaand);

                lblTypeLoon.Content = "dagen";
                
                tbxVoornaam.Text = bediende.Voornaam;
                tbxNaam.Text = bediende.Naam;
                tbxBedrijfswagen.Text = "";
                rbBediende.IsChecked = true;
            }
            catch (Exception)
            {

            }
            try
            {
                Kaderlid kaderlid = (Kaderlid)werknemer;
                Bedrijfswagen bedrijfswagen = kaderlid.BedrijfswagenKaderlid;
                stringBuilder.AppendLine("Bedrijfswagen: " + bedrijfswagen.Type);
                stringBuilder.AppendLine("Prestaties: " + kaderlid.GepresteerdeDagenMaand);

                lblTypeLoon.Content = "dagen";

                tbxVoornaam.Text = kaderlid.Voornaam;
                tbxNaam.Text = kaderlid.Naam;
                tbxBedrijfswagen.Text = bedrijfswagen.Type;
                rbKaderlid.IsChecked = true;
            }
            catch (Exception)
            {

            }
            lblWerknemerInfo.Content = stringBuilder.ToString();

        }
        private void PrestatieToevoegen(int aantal)
        {
            Werknemer werknemer = Werknemers[dgWerknemers.SelectedIndex];
            
            try
            {
                Arbeider arbeider = (Arbeider)werknemer;
                arbeider.GepresteerdeUrenMaand = arbeider.GepresteerdeUrenMaand + aantal;
            }
            catch (Exception)
            {

            }
            try
            {
                Bediende bediende = (Bediende)werknemer;
                bediende.GepresteerdeDagenMaand = bediende.GepresteerdeDagenMaand + aantal;
            }
            catch (Exception)
            {

            }
            try
            {
                Kaderlid kaderlid = (Kaderlid)werknemer;
                kaderlid.GepresteerdeDagenMaand = kaderlid.GepresteerdeDagenMaand + aantal;
            }
            catch (Exception)
            {

            }
            WerknemerInfo();
        }
        private void Foutmelding()
        {
            string foutmelding = "Gelieve alles in te vullen";
            MessageBox.Show(foutmelding);

        }
    }
}
