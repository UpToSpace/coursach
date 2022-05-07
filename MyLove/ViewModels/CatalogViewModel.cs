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
    class CatalogViewModel : ViewModel
    {
        public CatalogViewModel(Infrastructure.Stores.NavigationStore navigationStore, Func<EraViewModel> eraViewModel)
        {
            GoToEraPageCommand = new NavigateCommand(navigationStore, eraViewModel);
        }

        public ICommand GoToEraPageCommand { get; }
    }
}
