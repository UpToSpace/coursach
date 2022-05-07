using MyLove.Infrastructure.Stores;
using MyLove.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyLove
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore profileNavigationStore;
        private readonly NavigationStore catalogNavigationStore;
        public App()
        {
            profileNavigationStore = new NavigationStore();
            catalogNavigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            profileNavigationStore.CurrentViewModel = CreateLoginViewModel();
            catalogNavigationStore.CurrentViewModel = CreateCatalogViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel(profileNavigationStore, catalogNavigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e); 
        }

        private RegistrationViewModel CreateRegistrationViewModel()
        {
            return new RegistrationViewModel(profileNavigationStore, CreateLoginViewModel);
        }

        private LoginViewModel CreateLoginViewModel()
        {
            return new LoginViewModel(profileNavigationStore, CreateRegistrationViewModel);
        }

        private CatalogViewModel CreateCatalogViewModel()
        {
            return new CatalogViewModel(catalogNavigationStore, CreateEraViewModel);
        }

        private EraViewModel CreateEraViewModel()
        {
            return new EraViewModel(catalogNavigationStore, CreateCatalogViewModel);
        }
    }
}
