using CommunityToolkit.Mvvm.Input;
using MVVM2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM2.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private ObservableCollection<User> _Users;
        private User _GeselecteerdeUser;

        public UserViewModel()
        {
            _Users = new ObservableCollection<User>();

            User user = new User();
            user.Id = 1;
            user.UserName = "Maarten";
            user.Les = "Smurfen";
            Users.Add(user);

            user = new User();
            user.Id = 2;
            user.UserName = "Kim";
            user.Les = "Vliegen";
            Users.Add(user);

            user = new User();
            user.Id = 3;
            user.UserName = "Lyen";
            user.Les = "Lerenleren";
            Users.Add(user);

            NewUserCommandHandler = new RelayCommand(OnAddUser, CanAddUser);
            NewDetailWindowCommandHandler = new RelayCommand<object>(OpenDetailWindow);
        }

        private void OpenDetailWindow(object? obj)
        {
            throw new NotImplementedException();
        }

        private bool CanAddUser()
        {
            return true;
            //throw new NotImplementedException();
        }

        private void OnAddUser()
        {
            //throw new NotImplementedException();
        }

        public RelayCommand NewUserCommandHandler { get; private set; }
        public RelayCommand<object> NewDetailWindowCommandHandler { get; private set; }

        public ObservableCollection<User> Users
        {
            get { return _Users; }
            set 
            {
                _Users = value;
                OnPropertyChanged("Users");
            }
        }

        public User GeselecteerdeUser
        {
            get { return _GeselecteerdeUser; }
            set 
            {
                _GeselecteerdeUser = value;
                OnPropertyChanged("GeselecteerdeUser");
            }
        }

    }
}
