using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Examenopdracht
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            NieuweComputer();
        }
        //COMPUTERS LIJST
        public string _type;
        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }
        public string uniekeComputernaam;
        public string UniekeComputernaam
        {
            get => uniekeComputernaam;
            set
            {
                uniekeComputernaam = value;
                OnPropertyChanged("UniekeComputernaam");
            }
        }
        public int _bouwjaar;
        public int Bouwjaar
        {
            get => _bouwjaar;
            set
            {
                _bouwjaar = value;
                OnPropertyChanged("Bouwjaar");
            }
        }
        public int _computerLeeftijd;
        public int ComputerLeeftijd
        {
            get => _computerLeeftijd;
            set
            {
                _computerLeeftijd = value;
                OnPropertyChanged("ComputerLeeftijd");
            }
        }
        public decimal _aankoopprijs;
        public decimal Aankoopprijs
        {
            get => _aankoopprijs;
            set
            {
                _aankoopprijs = value;
                OnPropertyChanged("Aankoopprijs");
            }
        }
        public List<Software> SoftwareLijst { get; set; } = new List<Software>();

        private Computer _geselecteerdeComputer;
        public ObservableCollection<Computer> ComputerLijst { get; set; } = new ObservableCollection<Computer>();
      
        public Computer GeselecteerdeComputer
        {
            get => _geselecteerdeComputer;
            set
            {
                _geselecteerdeComputer = value;
                OnPropertyChanged("GeselecteerdeComputer");
                SetGeselecteerdeComputer();
            }
        }
        private void SetGeselecteerdeComputer()
        {
            if (GeselecteerdeComputer != null)
            {
                Type = GeselecteerdeComputer.Type;
                UniekeComputernaam = GeselecteerdeComputer.UniekeComputernaam;
                Bouwjaar = GeselecteerdeComputer.Bouwjaar;
                ComputerLeeftijd = GeselecteerdeComputer.ComputerLeeftijd;
                Aankoopprijs = GeselecteerdeComputer.Aankoopprijs;
            }
        }

        //COMPUTERS DATA

        public DelegateCommand CmdNieuweComputer
        {
            get
            {
                return new DelegateCommand(NieuweComputer);
            }
        }
        public void NieuweComputer()
        {
            Computer nieuweComputer = new Computer();
            GeselecteerdeComputer = nieuweComputer;
        }
        public DelegateCommand CmdBewaarComputer
        {
            get
            {
                return new DelegateCommand(BewaarComputer);
            }
        }
        public void BewaarComputer()
        {
            if (GeselecteerdeComputer != null)
            {
                Computer computer = GeselecteerdeComputer.NieuwComputerAanmaken(Type, UniekeComputernaam, Bouwjaar, Aankoopprijs, SoftwareLijst);
                ComputerLijst.Add(computer);
                GeselecteerdeComputer = computer;
            }
        }
        public DelegateCommand CmdVerwijderComputer
        {
            get
            {
                return new DelegateCommand(VerwijderComputer);
            }
        }
        public void VerwijderComputer()
        {
            if (GeselecteerdeComputer != null)
            {
                Computer computer = GeselecteerdeComputer;
                ComputerLijst.Remove(computer);
                NieuweComputer();
            }
        }
        public DelegateCommand CmdPrint
        {
            get
            {
                return new DelegateCommand(PrintComputer);
            }
        }
        public void PrintComputer()
        {
            MessageBox.Show(GeselecteerdeComputer.ToString(), "Computeriformatie");
        }

        //SOFTWARE LIJST
        private string _geselecteerdeSoftware;
        public List<string> Software { get; } = new List<string>() { "Windows", "Office" };
        public string GeselecteerdeSoftware
        {
            get => _geselecteerdeSoftware;
            set
            {
                _geselecteerdeSoftware = value;
               
                OnPropertyChanged(nameof(IsStandaardLettertypeAanpasbaar));
            }
        }
        //private void SetGeselecteerdeSoftware()
        //{
        //    if (GeselecteerdeSoftware != null)
        //    {
        //        SoftwareType = GeselecteerdeSoftware.SoftwareType;
        //        Softwarenaam = GeselecteerdeSoftware.Softwarenaam;
        //        Licentienummer = GeselecteerdeSoftware.Licentienummer;
        //        Uitgavejaar = GeselecteerdeSoftware.Uitgavejaar;
        //        StandaardLettertype = GeselecteerdeSoftware.StandaardLettertype;
        //    }
        //}


        public string _softwareType;
        public string SoftwareType
        {
            get => _softwareType;
            set
            {
                _softwareType = value;
                OnPropertyChanged("SoftwareType");
            }
        }
        public string _softwarenaam;
        public string Softwarenaam
        {
            get => _softwarenaam;
            set
            {
                _softwarenaam = value;
                OnPropertyChanged("Softwarenaam");
            }
        }
        public int _licentienummer;
        public int Licentienummer
        {
            get => _licentienummer;
            set
            {
                _licentienummer = value;
                OnPropertyChanged("Licentienummer");
            }
        }
        public int _uitgavejaar;
        public int Uitgavejaar
        {
            get => _uitgavejaar;
            set
            {
                _uitgavejaar = value;
                OnPropertyChanged("Uitgavejaar");
            }
        }
        public string _standaardLettertype;
        public string StandaardLettertype
        {
            get => _standaardLettertype;
            set
            {
                _standaardLettertype = value;
                OnPropertyChanged("StandaardLettertype");
            }
        }

        //SOFTWARE DATA
        public bool IsStandaardLettertypeAanpasbaar
        {
            get
            {
                return SoftwareType != "Windows";
            }
        }



    }
}
