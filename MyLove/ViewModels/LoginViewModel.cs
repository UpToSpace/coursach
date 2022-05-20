using MyLove.Database;
using MyLove.Infrastructure.Commands;
using MyLove.Models;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Validator = MyLove.Infrastructure.Validator.Validator;

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
            mainWindowViewModel.Role = Infrastructure.Roles.Roles.Guest;
            GoToRegistrationCommand = new NavigateCommand(this.mainWindowViewModel);
            GoToProfileCommand = new NavigateCommand(this.mainWindowViewModel);
            CheckDataCommand = new RelayCommand(OnCheckDataCommandExecuted);
        }

        public ICommand GoToRegistrationCommand { get; }
        public ICommand GoToProfileCommand { get; }
        public ICommand CheckDataCommand { get; }

        private void OnCheckDataCommandExecuted(object o)
        {
            foreach (var item in loginModel.Admins)
            {
                if (Username == item.Name && Password == item.Password)
                {
                    mainWindowViewModel.Admin = item;
                    mainWindowViewModel.Role = Infrastructure.Roles.Roles.Admin;
                    GoToProfileCommand.Execute("UserProfile");
                    return;
                }
            }
            User_ user = new User_();
            user.Username = Username;
            user.Password = Password;
            if (!Validator.Validate(user))
            {
                return;
            }

            MD5 passwordHasher = MD5.Create();
            user.Password = Convert.ToBase64String(passwordHasher.ComputeHash(Encoding.UTF8.GetBytes(Password)));

            foreach (var item in loginModel.Users)
            {
                if (Username == item.Username && user.Password == item.Password)
                {
                    mainWindowViewModel.User = item;
                    mainWindowViewModel.Role = Infrastructure.Roles.Roles.User;
                    GoToProfileCommand.Execute("UserProfile");
                    return;
                }
            }
            MessageBox.Show("This user not exists or password is incorrect");
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