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
        private MainWindowViewModel mainWindowViewModel;
        public ObservableCollection<Era> Eras 
        {
            get => eras;
        }
        
        public CatalogViewModel(MainWindowViewModel mainWindowViewModel)
        {
            catalogModel = new CatalogModel();
            this.mainWindowViewModel = mainWindowViewModel;
            GoToEraPageCommand = new NavigateCommand(mainWindowViewModel);
            ShowEraCommand = new RelayCommand(OnCheckDataCommandExecuted);
            eras = new ObservableCollection<Era>(catalogModel.Eras);
        }
        public ICommand GoToEraPageCommand { get; }
        public ICommand ShowEraCommand { get; }

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
        private void OnCheckDataCommandExecuted(object o)
        {
            if (mainWindowViewModel.User != null)
            {
                Travels travel = new Travels();
                travel.era_id = mainWindowViewModel.Era.id;
                travel.User_ = mainWindowViewModel.User;
                mainWindowViewModel.User.Travels.Add(travel);
            }
            mainWindowViewModel.Era = o as Era;
            GoToEraPageCommand.Execute("Era");
        }
    }
}
