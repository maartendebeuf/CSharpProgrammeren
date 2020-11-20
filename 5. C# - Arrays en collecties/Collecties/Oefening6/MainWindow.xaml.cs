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

namespace Oefening6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Maak een programma met een `ComboBox`, `TextBox` en twee `Buttons`. Het programma heeft volgende eigenschappen:
            //*De `ComboBox` heeft een hoogte van *30 pixels* en een breedte van * 200 pixels *.
            //* De `ComboBox` bevat een lijst met dranken.
            //* Het tweede element in de `ComboBox` is standaard geselecteerd.
            //*De eerste `Button` voegt de tekst uit de `TextBox` toe aan de lijst.
            //*De tweede `Button` verwijdert het **geselecteerde * *element.
            
            List<string> drankenlijst = new List<string>() { "water", "cola" ,"fruitsap"};

        }
        private List<string> drankenlijst
        {
            
            set { }    
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string nieuweDrank = tbNieuweDrank.Text;
            if (string.IsNullOrEmpty(nieuweDrank) || string.IsNullOrWhiteSpace(nieuweDrank))
            {
                lblfouten.Content = "geef een waarde in";
            }
            else
            {
                cbDrankenlijst.ItemsSource
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
