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

        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object o) => true;
        private void OnCloseApplicationCommandExecuted(object o)
        {

        }

        public ICommand ChangeThemeCommand { get; }
        private void OnChangeThemeCommandExecuted(object o)
        {
            string theme = o as string;
            switch (theme)
            {
                case "light":
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("./Views/Themes/LightTheme.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "dark":
                    Application.Current.Resources.MergedDictionaries[1].Source = new Uri("./Views/Themes/DarkTheme.xaml", UriKind.RelativeOrAbsolute);
                    break;
                default:
                    break;
            }
        }


        public MainWindowViewModel()
        {
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangeThemeCommand = new RelayCommand(OnChangeThemeCommandExecuted);
        }
    }
}
