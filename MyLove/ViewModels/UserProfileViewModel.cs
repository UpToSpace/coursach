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
    class UserProfileViewModel : ViewModel
    {
        private UserProfileModel userProfileModel;
        private Admin admin;
        private User_ user;
        public User_ User { get => user; set => user = value; }
        public Admin Admin { get => admin; set => Set(ref admin, value); }

        private List<Travel> travels;
        public List<Travel> Travels { get => travels; set => Set(ref travels, value); }

        private MainWindowViewModel mainWindowViewModel;
        public UserProfileViewModel(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
           userProfileModel = new UserProfileModel(mainWindowViewModel);
           GoToLoginPageCommand = new NavigateCommand(mainWindowViewModel);
           User = mainWindowViewModel.User;
           Admin = mainWindowViewModel.Admin;
           Travels = userProfileModel.GetTravels(User).ToList();
        }

        public ICommand GoToLoginPageCommand { get; }
    }
}
