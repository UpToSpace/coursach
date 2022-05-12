using MyLove.Database;
using MyLove.Infrastructure.Commands;
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


        public MainWindowViewModel()
        {
            mainWindowModel = new MainWindowModel();
            CurrentViewModel = new MainViewModel(this);
            GoToPageCommand = new NavigateCommand(this);
        }
        public ICommand GoToPageCommand { get; }
    }
}