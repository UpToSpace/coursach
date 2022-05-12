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
        private DbSet<Era> eras;
        public DbSet<Era> Eras { get => eras; set => eras = value; }
        //public IEnumerable<Travel> Travels { get; set; }

        private IEnumerable<Travel> travels;
        public UserProfileModel(ViewModel mainViewModel)
        {
            travels = coursachEntities.GetContext().Set<Travel>();
        }
        public List<Travel> GetTravels(User_ user)
        {
            return new List<Travel>(travels.Where(u => u.User_ == user).ToList());
        }
    }
}
