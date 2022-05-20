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
using System.Windows.Forms;
using System.Windows.Input;

namespace MyLove.ViewModels
{
    class FeedbacksViewModel : ViewModel
    {
        MainWindowViewModel mainWindowViewModel;
        private FeedbacksModel feedbacksModel;
        private List<Feedback> feedbacks;
        Feedback feedback;
        private User_ user;
        private string description;
        public FeedbacksViewModel(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
            User = mainWindowViewModel.User;
            Role = mainWindowViewModel.Role;
            feedbacksModel = new FeedbacksModel();
            feedbacks = feedbacksModel.Feedbacks.ToList();
            feedback = new Feedback();
            AddFeedbackCommand = new RelayCommand(OnAddFeedbackCommandExecuted);
        }

        public User_ User { get => user; set => Set(ref user, value); }
        public List<Feedback> Feedbacks { get => feedbacks; set => Set(ref feedbacks, value); }
        public Roles Role { get; set; }
        public ICommand AddFeedbackCommand { get; }
        public string Description { get => description; set => Set(ref description, value); }

        private void OnAddFeedbackCommandExecuted(object o)
        {
            if (Description.Length > 390)
            {
                MessageBox.Show("The length of the comment is too long");
                return;
            }
            feedback.Description = Description;
            feedback.Username = mainWindowViewModel.User.Username;
            feedback.User_ = mainWindowViewModel.User;
            feedbacksModel.AddFeedback(feedback);
            Feedbacks = feedbacksModel.Feedbacks.ToList();
            feedback = new Feedback();
        }
    }
}
