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
    class EraViewModel : ViewModel
    {
        private MainWindowViewModel mainWindowViewModel;
        private Era era;
        public Era Era { get => era; set => era = value; }

        public EraViewModel(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
            GoToCatalogPageCommand = new NavigateCommand(mainWindowViewModel);
            ShowCatalogCommand = new RelayCommand(OnShowCatalogCommandExecuted);
            Era = mainWindowViewModel.Era;
        }

        public ICommand GoToCatalogPageCommand { get; }
        public ICommand ShowCatalogCommand { get; }


        private void OnShowCatalogCommandExecuted(object o)
        {
            GoToCatalogPageCommand.Execute("Catalog");
        }
    }
}
