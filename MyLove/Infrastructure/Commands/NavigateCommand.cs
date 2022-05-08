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
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public NavigateCommand(NavigationStore navigationStore, Func<ViewModel> createViewModel, Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            execute = Execute;
            canExecute = CanExecute;
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }
        public NavigateCommand(NavigationStore navigationStore, Func<ViewModel> createViewModel, Func<object, bool> CanExecute = null)
        {
            canExecute = CanExecute;
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }

        //public NavigateCommand(NavigationStore navigationStore, Func<ViewModel> createViewModel)
        //{
        //    this.navigationStore = navigationStore;
        //    this.createViewModel = createViewModel;
        //}

        public override bool CanExecute(object parameter) => canExecute?.Invoke(parameter) ?? true;
        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = createViewModel();
            execute?.Invoke(parameter);
        }
    }
}
