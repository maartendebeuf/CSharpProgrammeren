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

namespace OefeningenBoek39
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
                
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            DateTime verjaardag = (DateTime)dateTimePicker.SelectedDate;
            int dagen = (int)(DateTime.Now - verjaardag).TotalDays;
            if (dagen < 18 * 356.25)
            {
                tbOutput.Text = "Je bent nog niet oud genoeg om te drinken";

            }
            else
            {
                if ((bool)rbMeisje.IsChecked)
                {
                    tbOutput.Text = "Wat wil je dan wel drinken?";
                }
                if ((bool)rbJongen.IsChecked)
                {
                    tbOutput.Text = "Enkel nog water te verkrijgen .";

                }
            }
        }
    }
}
