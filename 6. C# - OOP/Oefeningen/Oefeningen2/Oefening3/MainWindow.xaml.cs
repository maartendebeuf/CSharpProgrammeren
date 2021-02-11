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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        
        }
    }
}
