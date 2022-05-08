using MyLove.Infrastructure.Commands;
using MyLove.Models;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyLove.ViewModels
{
    class CatalogViewModel : ViewModel
    {
        private CatalogModel catalogModel;
        private ObservableCollection<Era> eras;
        private Era selectedEra;
        public ObservableCollection<Era> Eras 
        {
            get => eras;
            set
            {
                eras = value;
            }
        }
        
        public CatalogViewModel(Infrastructure.Stores.NavigationStore navigationStore, Func<EraViewModel> eraViewModel)
        {
            catalogModel = new CatalogModel();
            GoToEraPageCommand = new NavigateCommand(navigationStore, eraViewModel, OnGoToEraPageCommandExecuted);
            Eras = new ObservableCollection<Era>(catalogModel.Eras);
        }

        public void OnGoToEraPageCommandExecuted(object o)
        {
            selectedEra = o as Era;
            Container.era = selectedEra;
        }
        public ICommand GoToEraPageCommand { get; }
    }
}
