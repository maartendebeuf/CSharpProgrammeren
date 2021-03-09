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

namespace Oefening3_Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Team huidigTeam;
        private List<Lid> huidigeLeden = new List<Lid>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            // Maximum 4 leden per team!
            if(huidigTeam != null && huidigTeam.IsMaximumLedenBereikt())
            {
                MessageBox.Show("Het team bevat al vier leden.");
                return;
            }

            var naam = txtLidNaam.Text;
            var specialiteit = txtLidSpecialiteit.Text;

            var nieuwLid = new Lid(naam, specialiteit);
            // Controleer of de gevraagde gegevens ingevuld zijn.
            if (!huidigTeam.IsGeldigLid(nieuwLid))
            {
                MessageBox.Show("Niet alle gegevens zijn correct ingevuld.");
                return;
            }

            // Nieuw lid toevoegen aan lijst met huidige leden
            huidigeLeden.Add(nieuwLid);

            // Aanmaken team met nieuwe leden
            huidigTeam = new Team(huidigeLeden);

            // Toon gegevens
            ToonGegevens();
        }

        private void BtnStandaardTeam_Click(object sender, RoutedEventArgs e)
        {
            // Aanmaken team met standaard leden    
            huidigTeam = new Team();
            // Clear list met zelf aangemaakte leden
            huidigeLeden.Clear();
            ToonGegevens();
        }

        private void ToonGegevens()
        {
            // Controleer of het hudig team bestaat!
            if (huidigTeam != null)
            {
                lblTeamGegevens.Content = huidigTeam.ToString();
            }
        }
    }
}
