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

namespace OefeningenBoek40
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
               
        private bool meisje;        
        private void cbMeisje_Checked(object sender, RoutedEventArgs e)
        {
            cbJongen.IsChecked = false;
            meisje = true;

        }

        private void cbJongen_Checked(object sender, RoutedEventArgs e)
        {
            cbMeisje.IsChecked = false;
            meisje = !true;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            DateTime geboortedatum = (DateTime)dateTimePicker.SelectedDate;
            DateTime schoolfeestdatum = (DateTime)dateTimePicker_Copy.SelectedDate;
            int dagen = (int)(DateTime.Now - geboortedatum).TotalDays;
            if (dagen < 18 * 356.25)
            {
                tbOutput.Text = "Je bent nog niet oud genoeg om te drinken.\n" +
                        "Je mag pas alcohol drinken vanaf " + geboortedatum.AddYears(18).ToShortDateString();

            }
            else
            {
                if (meisje)
                {
                    tbOutput.Text = "Wat wil je dan wel drinken?";
                }
                else
                {
                    tbOutput.Text = "Enkel nog water te verkrijgen.";


                }
            }
        }

        private void btnStart_Copy_Click(object sender, RoutedEventArgs e)
        {
            DateTime geboortedatum = (DateTime)dateTimePicker.SelectedDate;
            DateTime schoolfeestdatum = (DateTime)dateTimePicker_Copy.SelectedDate;
            if (schoolfeestdatum< geboortedatum.AddYears(18))
            {
                tbOutput.Text = "Dikke pech.";
            }
            else
            {
                tbOutput.Text = "Proficiat maar toch opletten he";
            }
        }
    }
}
