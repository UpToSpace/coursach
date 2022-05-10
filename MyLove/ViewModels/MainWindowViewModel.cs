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
        private Era newEra;
        private Era era;

        #region Navigation

        private ViewModel profileCurrentViewModel;
        public ViewModel ProfileCurrentViewModel
        {
            get => profileCurrentViewModel;
            set
            {
                Set(ref profileCurrentViewModel, value);
            }
        }
        private ViewModel catalogCurrentViewModel;
        public ViewModel CatalogCurrentViewModel
        {
            get => catalogCurrentViewModel;
            set
            {
                Set(ref catalogCurrentViewModel, value);
            }
        }

        #endregion

        public Era Era { get => era; set => Set(ref era, value); }
        public User_ User { get => user; set => user = value; }
        public Era NewEra { get => newEra; set => Set(ref newEra, value); }

        public MainWindowViewModel()
        {
            mainWindowModel = new MainWindowModel();

            ProfileCurrentViewModel = new LoginViewModel(this);
            CatalogCurrentViewModel = new CatalogViewModel(this);

            newEra = new Era();
            AddEraCommand = new RelayCommand(OnAddEraCommandExecuted);

            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangeThemeCommand = new RelayCommand(OnChangeThemeCommandExecuted);
            ChangeLanguageCommand = new RelayCommand(OnChangeLanguageCommandExecuted);
        }

        public ICommand AddEraCommand { get; }
        private void OnAddEraCommandExecuted(object o)
        {
            mainWindowModel.AddNewEra(NewEra);
        }

        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object o) => true;
        private void OnCloseApplicationCommandExecuted(object o)
        {

        }

        #region Change Theme

        public ICommand ChangeThemeCommand { get; }
        private void OnChangeThemeCommandExecuted(object o)
        {
            string theme = o as string;
            switch (theme)
            {
                case "Light":
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("./Views/Themes/LightTheme.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "Dark":
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("./Views/Themes/DarkTheme.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Change Language
        public ICommand ChangeLanguageCommand { get; }

        private void OnChangeLanguageCommandExecuted(object o)
        {
            string lang = o as string;
            switch (lang)
            {
                case "EN":
                    Application.Current.Resources.MergedDictionaries[2].Source = new Uri("./Views/Languages/En.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "RU":
                    Application.Current.Resources.MergedDictionaries[2].Source = new Uri("./Views/Languages/Ru.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}