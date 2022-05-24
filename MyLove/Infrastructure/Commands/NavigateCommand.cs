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
	class NavigateCommand : Command
	{
		private MainWindowViewModel viewModel;
		public NavigateCommand(MainWindowViewModel viewModel)
		{
			this.viewModel = viewModel;
		}

		public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
			switch (parameter as string)
			{
				case "Main":
					viewModel.CurrentViewModel = new MainViewModel(viewModel);
					break;
				case "Catalog":
					viewModel.CurrentViewModel = new CatalogViewModel(viewModel);
					break;
				case "Era":
					viewModel.CurrentViewModel = new EraViewModel(viewModel);
					break;
				case "New":
					viewModel.CurrentViewModel = new NewViewModel(viewModel);
					break;
				case "Login":
					if (viewModel.User == null && viewModel.Admin == null)
					{
						viewModel.CurrentViewModel = new LoginViewModel(viewModel);
						break;
					}
					viewModel.CurrentViewModel = new UserProfileViewModel(viewModel);
					break;
				case "Registration":
					viewModel.CurrentViewModel = new RegistrationViewModel(viewModel);
					break;
				case "UserProfile":
					viewModel.CurrentViewModel = new UserProfileViewModel(viewModel);
					break;
				case "Logout":
					viewModel.User = null;
					viewModel.Admin = null;
					viewModel.Role = Roles.Roles.Guest;
					viewModel.CurrentViewModel = new LoginViewModel(viewModel);
					break;
				case "Feedbacks":
					viewModel.CurrentViewModel = new FeedbacksViewModel(viewModel);
					break;
				case "Settings":
					viewModel.CurrentViewModel = new SettingsViewModel(viewModel);
					break;
				default:
					break;
			}
		}
    }
}
