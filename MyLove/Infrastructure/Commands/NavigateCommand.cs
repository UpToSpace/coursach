using MyLove.Infrastructure.Commands.Base;
using MyLove.Infrastructure.Stores;
using MyLove.ViewModels;
using MyLove.ViewModels.Base;
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
        private readonly Func<ViewModel> createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<ViewModel> createViewModel)
        {
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = createViewModel();
        }
    }
}
