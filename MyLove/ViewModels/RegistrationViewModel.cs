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
            //if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            //{
            //    MessageBox.Show("The fields are empty");
            //    return;
            //}
            foreach (var item in registrationModel.Users)
            {
                if (Username == item.Username)
                {
                    MessageBox.Show("The user already exists");
                    return;
                }
            }
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

            MD5 passwordHasher = MD5.Create();
            user.Password = Convert.ToBase64String(passwordHasher.ComputeHash(Encoding.UTF8.GetBytes(Password)));
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

