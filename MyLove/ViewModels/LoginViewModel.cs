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
        public LoginViewModel(NavigationStore navigationStore)
        {
            LoginCommand = new NavigateCommand(navigationStore);
        }

        public ICommand LoginCommand { get; }


    }
}
