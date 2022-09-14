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

namespace Oefening3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //## Oefening 3

    //Quiz123 houdt de gegevens bij van de aangesloten quiz-teams.
    //Ieder team bestaat uit 4 leden.Elk lid heeft een bepaalde specialiteit, bijvoorbeeld sport, film en muziek,…\
    //Maak een klasse Lid.Geef de klasse een constructor waarmee je de naam van het lid en zijn/haar specialiteit kan invoeren. 
    //Geef de klasse ook een methode Print( ) die de properties van het betreffende lid op het scherm weergeeft.\
    //Maak een klasse Team die 4 instanties van Lid maakt. 
    //Geef de klasse een methode PrintAlleLeden() die de namen van de leden en hun specialiteiten op het scherm toont.\
    //Voorzie twee constructors, één waar de leden in de constructor aangemaakt worden en één waar je een lijst van leden aan kan meegeven.


    public partial class MainWindow : Window
    {
        List<Team> teams= new List<Team>();
        public MainWindow()
        {
            InitializeComponent();
            dgTeams.ItemsSource = teams;
        }      

        private void btnTeamAanmaken_Click(object sender, RoutedEventArgs e)
        {
            CreateTeam();
            dgTeams.Items.Refresh();
        }  
        
        private void CreateTeam()
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(tbTeamNaam.Text)
                    && string.IsNullOrWhiteSpace(tbLidNaam1.Text)
                    && string.IsNullOrWhiteSpace(tbLidNaam2.Text)
                    && string.IsNullOrWhiteSpace(tbLidNaam3.Text)
                    && string.IsNullOrWhiteSpace(tbLidNaam4.Text)
                    && string.IsNullOrWhiteSpace(tbLidSpecialiteit1.Text)
                    && string.IsNullOrWhiteSpace(tbLidSpecialiteit2.Text)
                    && string.IsNullOrWhiteSpace(tbLidSpecialiteit3.Text)
                    && string.IsNullOrWhiteSpace(tbLidSpecialiteit4.Text)))
                {
                    Team team = new Team(tbTeamNaam.Text, tbLidNaam1.Text, tbLidSpecialiteit1.Text
                        , tbLidNaam2.Text, tbLidSpecialiteit2.Text
                        , tbLidNaam3.Text, tbLidSpecialiteit3.Text
                        , tbLidNaam4.Text, tbLidSpecialiteit4.Text);
                    teams.Add(team);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
