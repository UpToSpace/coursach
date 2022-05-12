using MyLove.Database;
using MyLove.Infrastructure.Commands;
using MyLove.Models;
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
        EraModel eraModel;
        public Era Era { get => era; set => era = value; }

        public EraViewModel(MainWindowViewModel mainWindowViewModel)
        {
            eraModel = new EraModel();
            this.mainWindowViewModel = mainWindowViewModel;
            GoToCatalogPageCommand = new NavigateCommand(mainWindowViewModel);
            ShowCatalogCommand = new RelayCommand(OnShowCatalogCommandExecuted);
            Era = mainWindowViewModel.Era;
        }

        public ICommand GoToCatalogPageCommand { get; }
        public ICommand ShowCatalogCommand { get; }


        private void OnShowCatalogCommandExecuted(object o)
        {
            if (mainWindowViewModel.User != null)
            {
                Travel travel = new Travel();
                travel.EraId = Era.Id;
                travel.Username = mainWindowViewModel.User.Username;
                travel.User_ = mainWindowViewModel.User;
                travel.Era = Era;
                eraModel.AddUserTravel(travel);
                OnPropertyChanged("Travels");
            }
            GoToCatalogPageCommand.Execute("Catalog");
        }
    }
}
