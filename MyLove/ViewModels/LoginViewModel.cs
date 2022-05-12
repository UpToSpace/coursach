using MyLove.Infrastructure.Commands;
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
        private MainWindowViewModel mainWindowViewModel;

        public LoginViewModel(MainWindowViewModel mainWindowViewModel)
        {
            loginModel = new LoginModel();
            this.mainWindowViewModel = mainWindowViewModel;
            mainWindowViewModel.User = null;
            GoToRegistrationCommand = new NavigateCommand(this.mainWindowViewModel);
            GoToProfileCommand = new NavigateCommand(this.mainWindowViewModel);
            CheckDataCommand = new RelayCommand(OnCheckDataCommandExecuted);
        }

        public ICommand GoToRegistrationCommand { get; }
        public ICommand GoToProfileCommand { get; }
        public ICommand CheckDataCommand { get; }

        private void OnCheckDataCommandExecuted(object o)
        {
            foreach (var item in loginModel.Users)
            {
                if (Username == item.Username && Password == item.Password)
                {
                    mainWindowViewModel.User = item;
                    GoToProfileCommand.Execute("UserProfile");
                }
            }
            foreach (var item in loginModel.Admins)
            {
                if (Username == item.Name && Password == item.Password)
                {
                    GoToProfileCommand.Execute("UserProfile");
                }
            }
        }
        public string Username
        {
            get { return username; }
            set
            {
                Set(ref username, value);
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                Set(ref password, value);
            }
        }
    }
}