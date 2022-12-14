using MVVM_klassikaal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using MVVM_klassikaal.Views;

namespace MVVM_klassikaal.ViewModels
{
    public class HoofdvensterVM : BasisVM
    {

        public RelayCommand DetailsCmd { get; private set; }
        public RelayCommand DetailsParCmd { get; private set; }

        public HoofdvensterVM()
        {
            _Gebruikers = new ObservableCollection<Gebruiker>();

            DetailsCmd = new RelayCommand(OnDetails);
            DetailsParCmd = new RelayCommand(OnDetailsParam);
            Gebruiker g = new Gebruiker();
            g.GebruikersId = 1;
            g.GebruikersNaam = "Grote smurf";
            g.Les = "smurfen";

            _Gebruikers.Add(g);

            g = new Gebruiker();
            g.GebruikersId = 2;
            g.GebruikersNaam = "Spiderman";
            g.Les = "Weven";
            _Gebruikers.Add(g);

            g = new Gebruiker();
            g.GebruikersId = 3;
            g.GebruikersNaam = "Superman";
            g.Les = "Vliegen";
            _Gebruikers.Add(g);

        }

        private ObservableCollection<Gebruiker> _Gebruikers;


        private Gebruiker _SelGebr;
        public Gebruiker GeselecteerdeGebruiker
        {
            get { return _SelGebr; 
            }
            set { _SelGebr = value;
                OnPropertyChanged("GeselecteerdeGebruiker");
            }
        }

        public ObservableCollection<Gebruiker> Gebruikers
        {
            get { return _Gebruikers; }
            set { _Gebruikers = value; }
        }



        private void OnDetails()
        {
            //Code voor oproepen detailvenster
//            MessageBox.Show("Details");

            Detail vensterdetail= new Detail();
            DetailVM vm = new DetailVM();
            vm.user = GeselecteerdeGebruiker;
            vensterdetail.DataContext = vm;

            vensterdetail.Show();

        }

        private void OnDetailsParam()
        {
            //Code voor oproepen detailvenster
            //            MessageBox.Show("Details");

            Detail vensterdetail = new Detail();
            DetailVM vm = new DetailVM(GeselecteerdeGebruiker);
            //vm.user = GeselecteerdeGebruiker;
            vensterdetail.DataContext = vm;

            vensterdetail.Show();

        }

    }
}
