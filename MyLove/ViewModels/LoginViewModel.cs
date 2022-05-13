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
            User_ user = new User_();
            user.Username = Username;
            user.Password = Password;
            ValidationContext contex = new ValidationContext(user, null, null);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(user, contex, errors, true))
            {
                foreach (var item in errors)
                {
                    MessageBox.Show(item.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            SHA256Managed hasher = new SHA256Managed();
            byte[] hashed = hasher.ComputeHash(Convert.FromBase64String(Password));
            string hashedPassword = Convert.ToBase64String(hashed);

            foreach (var item in loginModel.Users)
            {
                if (Username == item.Username && hashedPassword == item.Password)
                {
                    mainWindowViewModel.User = item;
                    GoToProfileCommand.Execute("UserProfile");
                    return;
                }
            }
            foreach (var item in loginModel.Admins)
            {
                if (Username == item.Name && Password == item.Password)
                {
                    mainWindowViewModel.Admin = item;
                    GoToProfileCommand.Execute("UserProfile");
                    return;
                }
            }
            MessageBox.Show("This user not exists");
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