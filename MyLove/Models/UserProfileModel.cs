using MyLove.Database;
using MyLove.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class UserProfileModel
    {
        private IEnumerable<Travel> travels;
        public UserProfileModel(ViewModel mainViewModel)
        {
            travels = coursachEntities.GetContext().Set<Travel>();
        }
        public int GetErasCount(User_ user)
        {
            return coursachEntities.GetContext().Set<Era>().Count();
        }
        public List<Travel> GetTravels(User_ user)
        {
            return new List<Travel>(travels.Where(u => u.User_ == user).ToList());
        }
    }
}
