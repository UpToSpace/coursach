using MyLove.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class FeedbacksModel
    {
        private DbSet<Feedback> feedbacks;

        public FeedbacksModel()
        {
            feedbacks = coursachEntities.GetContext().Set<Feedback>();
        }

        public DbSet<Feedback> Feedbacks { get => feedbacks; set => feedbacks = value; }

        public void AddFeedback(Feedback feedback)
        {
            feedback.Id = feedbacks.Count() + 1;
            Feedbacks.Add(feedback);
            coursachEntities.GetContext().SaveChanges();
        }
    }
}
