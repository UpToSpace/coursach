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
    class RegistrationViewModel : ViewModel
    {
        private string username;
        private string password;
        private RegistrationModel registrationModel;

        public RegistrationViewModel(MainWindowViewModel mainWindowViewModel)
        {
            registrationModel = new RegistrationModel();
            GoToLoginPageCommand = new NavigateCommand(mainWindowViewModel);
            GoToProfileCommand = new NavigateCommand(mainWindowViewModel);
        }

        public ICommand GoToLoginPageCommand { get; }
        public ICommand GoToProfileCommand { get; }

        private void OnGoToProfileCommandExecuted(object o)
        {
            User_ user = new User_();
            user.username = Username;
            user.password = Password;
            registrationModel.Users.Add(user);
            coursachEntities.GetContext().SaveChanges();
        }
        private bool CanGoToProfileCommandExecute(object o)
        {
            foreach (var item in registrationModel.Users)
            {
                if (Username == item.username)
                {
                    return false;
                }
            }
            foreach (var item in registrationModel.Admins)
            {
                if (Username == item.name && Password == item.password)
                {
                    return false;
                }
            }
            return true;
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

