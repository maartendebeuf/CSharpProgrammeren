using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;

namespace MVVM_klassikaal.Models
{
    public class Gebruiker : BasisModel
    {
        public Gebruiker() { }

        private string _GebruikersNaam;
        private int _Uid;
        private string _Les;


        public string GebruikersNaam
        {
            get
            {
                return _GebruikersNaam;
            }
            set {
                _GebruikersNaam = value;
                OnPropertyChanged("GebruikersNaam");
            }
        }

        public int GebruikersId
        {
            get
            {
                return _Uid;
            }
            set
            {
                _Uid = value;
                OnPropertyChanged("GebruikersId");
            }
        }

        public string Les
        {
            get
            {
                return _Les;
            }
            set
            {
                _Les = value;
                OnPropertyChanged("Les");
            }
        }
    }
}
