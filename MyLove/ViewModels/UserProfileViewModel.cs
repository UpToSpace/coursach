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
        private int travelValue;
        private string status;
        private string imagePath;
        private string favouriteCategory;
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
            travelValue = userProfileModel.GetErasCount(User) / Travels.Count() * 100;
            imagePath = GetImage();
            favouriteCategory = Travels.GroupBy(e => e.Era.Category).OrderByDescending(e => e.Count()).Select(e => e.Key).First();
        }

        public ICommand GoToLoginPageCommand { get; }
        public int TravelValue { get => travelValue; set => travelValue = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string Status { get => status; set => status = value; }
        public string FavouriteCategory { get => favouriteCategory; set => favouriteCategory = value; }

        private string GetImage()
        {
            if (travelValue <= 30)
            {
                Status = "Нуб";
                return @"D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\noob.jpg";
            }
            if (travelValue > 30 && travelValue <= 80)
            {
                Status = "Середняк";
                return @"D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\middle.jpg";
            }
            Status = "Маэстро";
            return @"D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\maestro.jpg";
        }
    }
}
