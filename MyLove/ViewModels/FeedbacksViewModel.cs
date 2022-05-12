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
    class FeedbacksViewModel : ViewModel
    {
        MainWindowViewModel mainWindowViewModel;
        private FeedbacksModel feedbacksModel;
        private List<Feedback> feedbacks;
        private string description;
        public FeedbacksViewModel(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
            feedbacksModel = new FeedbacksModel();
            feedbacks = feedbacksModel.Feedbacks.ToList();
            AddFeedbackCommand = new RelayCommand(OnAddFeedbackCommandExecuted);
        }

        public List<Feedback> Feedbacks { get => feedbacks; set => Set(ref feedbacks, value); }
        public ICommand AddFeedbackCommand { get; }
        public string Description { get => description; set => Set(ref description, value); }

        private void OnAddFeedbackCommandExecuted(object o)
        {
            Feedback feedback = new Feedback();
            feedback.Description = Description;
            feedback.Username = mainWindowViewModel.User.Username;
            feedback.User_ = mainWindowViewModel.User;
            feedbacksModel.AddFeedback(feedback);
            Feedbacks = feedbacksModel.Feedbacks.ToList();
        }
    }
}
