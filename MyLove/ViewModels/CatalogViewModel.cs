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
        private Era era;
        public ObservableCollection<Era> Eras 
        {
            get => eras;
            //set
            //{
            //    eras = value;
            //}
        }
        
        public CatalogViewModel(MainWindowViewModel mainWindowViewModel)
        {
            catalogModel = new CatalogModel();
            GoToEraPageCommand = new NavigateCommand(mainWindowViewModel);
            eras = new ObservableCollection<Era>(catalogModel.Eras);
        }

        public void OnGoToEraPageCommandExecuted(object o)
        {
            era = o as Era;
        }
        public ICommand GoToEraPageCommand { get; }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                Set(ref searchText, value);
                eras = new ObservableCollection<Era>(catalogModel.Eras.Where(e => e.name.Contains(SearchText)));
                OnPropertyChanged("Eras");
            }
        }
    }
}
