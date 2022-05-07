using MyLove.Infrastructure.Commands;
using MyLove.Infrastructure.Stores;
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
        public LoginViewModel(NavigationStore navigationStore, Func<RegistrationViewModel> createRegistrationViewModel, Func<UserProfileViewModel> createUserProfileViewModel)
        {
            GoToRegistrationCommand = new NavigateCommand(navigationStore, createRegistrationViewModel);
            GoToProfileCommand = new NavigateCommand(navigationStore, createUserProfileViewModel);
        }

        public ICommand GoToRegistrationCommand { get; }
        public ICommand GoToProfileCommand { get; }

    }
}
