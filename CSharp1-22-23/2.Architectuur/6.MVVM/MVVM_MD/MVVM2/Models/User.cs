using MVVM_basic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM2.Models
{
    public class User : ModelBaseClass
    {

        public User()
        {

        }
        private string _UserName;
        private int _Id;
        private string _Les;

        public string UserName
        {
            get { return _UserName; }
            set 
            { 
                _UserName = value;
                OnPropertyChanged("UserName");
                //of:OnPropertyChanged(nameof(UserName));
            }
        }

        public int Id
        {
            get { return _Id; }
            set 
            {
                _Id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Les
        {
            get { return _Les; }
            set 
            {
                _Les = value;
                OnPropertyChanged("Les");
            }
        }
    }
}
