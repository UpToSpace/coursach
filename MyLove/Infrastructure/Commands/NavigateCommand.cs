using MyLove.Infrastructure.Commands.Base;
using MyLove.Infrastructure.Stores;
using MyLove.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Infrastructure.Commands
{
    class NavigateCommand : Command
    {
        private readonly NavigationStore navigationStore;

        public NavigateCommand(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = new RegistrationViewModel(); // Устанавливаем на ккакую страницу попасть
        }
    }
}
