using MyLove.Database;
using MyLove.Infrastructure.Commands;
using MyLove.Infrastructure.Roles;
using MyLove.Models;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyLove.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private MainWindowModel mainWindowModel;
        private User_ user;
        private Admin admin;
        private Era era;
        private IEnumerable<string> categories;

        #region Navigation

        private ViewModel currentViewModel;
        public ViewModel CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                Set(ref currentViewModel, value);
            }
        }

        #endregion

        public Era Era { get => era; set => Set(ref era, value); }
        public User_ User { get => user; set => Set(ref user, value); }
        public Admin Admin { get => admin; set => Set(ref admin, value); }
        public IEnumerable<string> Categories { get => categories; set => categories = value; }
        public Roles Role { get; set; } = Roles.Guest;

        public MainWindowViewModel()
        {
            mainWindowModel = new MainWindowModel();
            CurrentViewModel = new MainViewModel(this);
            GoToPageCommand = new NavigateCommand(this);
            FullScreenApplicationCommand = new RelayCommand(OnFullScreenApplicationCommandExecuted);
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted);
            categories = new List<string>() { "Первобытный мир", "Древний мир", "Средние века", "Новое время", "Новейшее время" };
        }
        public ICommand GoToPageCommand { get; }
        public ICommand CloseApplicationCommand { get; }
        public ICommand FullScreenApplicationCommand { get; }


        private void OnCloseApplicationCommandExecuted(object o)
        {
            Application.Current.MainWindow.Close();
        }
        private void OnFullScreenApplicationCommandExecuted(object o)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }
    }
}