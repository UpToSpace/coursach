using MyLove.Database;
using MyLove.Infrastructure.Commands;
using MyLove.Infrastructure.Roles;
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
        private User_ user;
        private Admin admin;
        private MainWindowViewModel mainWindowViewModel;
        public ObservableCollection<Era> Eras 
        {
            get => eras;
            set => Set(ref eras, value);
        }
        
        public IEnumerable<string> Categories { get; set; }
        public Roles Role { get; set; } = Roles.Guest;
        public CatalogViewModel(MainWindowViewModel mainWindowViewModel)
        {
            catalogModel = new CatalogModel();
            this.mainWindowViewModel = mainWindowViewModel;
            GoToEraPageCommand = new NavigateCommand(mainWindowViewModel);
            DeleteEraCommand = new RelayCommand(OnDeleteEraCommandExecuted);
            ShowEraCommand = new RelayCommand(OnCheckDataCommandExecuted);
            ClearFilterCommand = new RelayCommand(OnClearFilterCommandExecuted);
            eras = new ObservableCollection<Era>(catalogModel.Eras);
            User = mainWindowViewModel.User;
            Admin = mainWindowViewModel.Admin;
            Categories = mainWindowViewModel.Categories;
            Role = mainWindowViewModel.Role;
        }
        public ICommand GoToEraPageCommand { get; }
        public ICommand ShowEraCommand { get; }
        public ICommand DeleteEraCommand { get; }
        public ICommand ClearFilterCommand { get; }
        public User_ User { get => user; set => Set(ref user, value); }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                Set(ref searchText, value);
                Eras = new ObservableCollection<Era>(catalogModel.Eras.Where(e => e.Name.Contains(SearchText)));
            }
        }

        private string selectedCategory;
        public string SelectedCategory
        {
            get { return selectedCategory; }
            set
            {
                Set(ref selectedCategory, value);
                Eras = new ObservableCollection<Era>(catalogModel.Eras.Where(e => e.Category.Contains(selectedCategory)));
            }
        }
        public Admin Admin { get => admin; set => admin = value; }

        private void OnCheckDataCommandExecuted(object o)
        {
            mainWindowViewModel.Era = o as Era;
            GoToEraPageCommand.Execute("Era");
        }
        private void OnDeleteEraCommandExecuted(object o)
        {
            Era era = o as Era;
            catalogModel.DeleteEra(era);
            Eras = new ObservableCollection<Era>(catalogModel.Eras);
        }
        private void OnClearFilterCommandExecuted(object o)
        {
            SelectedCategory = null;
            Eras = new ObservableCollection<Era>(catalogModel.Eras);
        }
    }
}
