using MyLove.Infrastructure.Commands;
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
        private User_ user;
        private ViewModel profileCurrentViewModel;
        public ViewModel ProfileCurrentViewModel
        {
            get => profileCurrentViewModel;
            set
            {
                Set(ref profileCurrentViewModel, value);
            }
        }
        public User_ User { get => user; set => user = value; }
        public MainWindowViewModel()
        {
            ProfileCurrentViewModel = new LoginViewModel(this);
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangeThemeCommand = new RelayCommand(OnChangeThemeCommandExecuted);
            ChangeLanguageCommand = new RelayCommand(OnChangeLanguageCommandExecuted);
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