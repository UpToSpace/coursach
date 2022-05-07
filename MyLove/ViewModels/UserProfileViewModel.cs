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
    class UserProfileViewModel : ViewModel
    {
        public UserProfileViewModel(Infrastructure.Stores.NavigationStore navigationStore, Func<LoginViewModel> createLoginViewModel)
        {
            GoToUserPageCommand = new NavigateCommand(navigationStore, createLoginViewModel);
        }

        public ICommand GoToUserPageCommand { get; }
    }
}
