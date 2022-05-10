using MyLove.Infrastructure.Commands.Base;
using MyLove.ViewModels;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyLove.Infrastructure.Commands
{
	class NavigateCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		private MainWindowViewModel viewModel;

		public NavigateCommand(MainWindowViewModel viewModel)
		{
			this.viewModel = viewModel;
		}

		public bool CanExecute(object parameter) => true;

		public void Execute(object parameter)
		{
			switch(parameter as string)
            {
				case "Login":
					viewModel.ProfileCurrentViewModel = new LoginViewModel(viewModel);
					break;
				case "Registration":
					viewModel.ProfileCurrentViewModel = new RegistrationViewModel(viewModel);
					break;
				case "UserProfile":
					viewModel.ProfileCurrentViewModel = new UserProfileViewModel(viewModel);
					break;
				case "Catalog":
					viewModel.CatalogCurrentViewModel = new CatalogViewModel(viewModel);
					break;
				case "Era":
					viewModel.CatalogCurrentViewModel = new EraViewModel(viewModel);
					break;
                default:
                    break;
            }
		}
	}
}
