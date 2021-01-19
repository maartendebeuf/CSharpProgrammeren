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

namespace Oefening1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //## Oefening 1 (WPF)

    //Zet in een form in het *load event* (dubbelklik ergens in je formulier of via events (bliksemschicht)
    // -> Loaded) de code om de volgende welkomstboodschap op het scherm te zetten.\
    //Hint: De naam van de ingelogde gebruiker verkrijg je met behulp van `Environment.UserName`.
    //> Beste (naam van de ingelogde gebruiker)\
    //> Welkom op dit formulier.  

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var gebruikersnaam = Environment.UserName;
            lblBoodschap.Content = "Beste " + gebruikersnaam + "\nWelkom op dit formulier.";
        }
    }
}
