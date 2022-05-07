using MyLove.Infrastructure.Commands;
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
        public RegistrationViewModel(Infrastructure.Stores.NavigationStore navigationStore, Func<LoginViewModel> createLoginViewModel, Func<UserProfileViewModel> createUserProfileViewModel)
        {
            GoToLoginPageCommand = new NavigateCommand(navigationStore, createLoginViewModel);
            GoToProfileCommand = new NavigateCommand(navigationStore, createUserProfileViewModel);
        }

        public ICommand GoToLoginPageCommand { get; }
        public ICommand GoToProfileCommand { get; }
    }
}
