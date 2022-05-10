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
    class UserProfileViewModel : ViewModel
    {
        private User_ user;
        public User_ User { get => user; set => user = value; }
        private MainWindowViewModel mainWindowViewModel;
        public UserProfileViewModel(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
           UserProfileModel userProfileModel = new UserProfileModel(mainWindowViewModel);
           GoToLoginPageCommand = new NavigateCommand(mainWindowViewModel);
            LogoutCommand = new RelayCommand(OnLogoutCommandCommandExecuted);
           User = mainWindowViewModel.User;
        }

        public ICommand GoToLoginPageCommand { get; }
        public ICommand LogoutCommand { get; }
        private void OnLogoutCommandCommandExecuted(object o)
        {
            mainWindowViewModel.User = null;
            GoToLoginPageCommand.Execute("Login");
        }
    }
}
