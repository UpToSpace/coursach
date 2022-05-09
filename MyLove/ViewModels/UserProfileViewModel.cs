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
        public UserProfileViewModel(MainWindowViewModel mainWindowViewModel)
        {
           //UserProfileModel userProfileModel = new UserProfileModel(mainWindowViewModel);
           GoToLoginPageCommand = new NavigateCommand(mainWindowViewModel);
            User = mainWindowViewModel.User;
        }

        public ICommand GoToLoginPageCommand { get; }
    }
}
