using MyLove.Infrastructure.Commands;
using MyLove.Models;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyLove.ViewModels
{
    class RegistrationViewModel : ViewModel
    {
        private string username;
        private string password;
        private RegistrationModel registrationModel;
        MainWindowViewModel mainWindowViewModel;

        public RegistrationViewModel(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
            registrationModel = new RegistrationModel();
            GoToLoginPageCommand = new NavigateCommand(mainWindowViewModel);
            GoToProfileCommand = new NavigateCommand(mainWindowViewModel);
            CheckDataCommand = new RelayCommand(OnCheckDataCommandExecuted);
        }

        public ICommand GoToLoginPageCommand { get; }
        public ICommand GoToProfileCommand { get; }
        public ICommand CheckDataCommand { get; }

        private void OnCheckDataCommandExecuted(object o)
        {
            foreach (var item in registrationModel.Users)
            {
                if (Username == item.username)
                {
                    MessageBox.Show("The user already exists");
                    return;
                }
            }
            User_ user = new User_();
            user.username = Username;
            user.password = Password;
            mainWindowViewModel.User = user;
            registrationModel.AddUser(user);
            GoToProfileCommand.Execute("UserProfile");
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

