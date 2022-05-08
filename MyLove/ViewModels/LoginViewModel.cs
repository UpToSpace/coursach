using MyLove.Infrastructure.Commands;
using MyLove.Infrastructure.Stores;
using MyLove.Models;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyLove.ViewModels
{
    class LoginViewModel : ViewModel
    {
        private string username;
        private string password;
        private LoginModel loginModel;

        public LoginViewModel(NavigationStore navigationStore, Func<RegistrationViewModel> createRegistrationViewModel, Func<UserProfileViewModel> createUserProfileViewModel)
        {
            loginModel = new LoginModel();
            GoToRegistrationCommand = new NavigateCommand(navigationStore, createRegistrationViewModel);
            GoToProfileCommand = new NavigateCommand(navigationStore, createUserProfileViewModel, CanGoToProfileCommandExecute);
        }

        public ICommand GoToRegistrationCommand { get; }
        public ICommand GoToProfileCommand { get; }

        private bool CanGoToProfileCommandExecute(object o)
        {
            foreach (var item in loginModel.Users)
            {
                if (Username == item.username && Password == item.password)
                {
                    return true;
                }
            }
            foreach (var item in loginModel.Admins)
            {
                if (Username == item.name && Password == item.password)
                {
                    return true;
                }
            }
            return false;
        }
        public string Username
        {
            get { return username; }
            set
            {
                Set(ref username, value);
                //OnPropertyChanged("Pictures");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                Set(ref password, value);
                //OnPropertyChanged("Pictures");
            }
        }
    }
}
