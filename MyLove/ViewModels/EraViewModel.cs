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
        private Era era;
        public EraViewModel(Infrastructure.Stores.NavigationStore navigationStore, Func<CatalogViewModel> catalogViewModel)
        {
            GoToCatalogPageCommand = new NavigateCommand(navigationStore, catalogViewModel);
            era = Container.era;
        }

        public ICommand GoToCatalogPageCommand { get; }
    }
}
