using MyLove.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class EraModel
    {
        private DbSet<Travel> travels;
        public EraModel()
        {
            Travels = coursachEntities.GetContext().Set<Travel>();
        }

        public DbSet<Travel> Travels { get => travels; set => travels = value; }

        public void AddUserTravel(Travel travel)
        {
            travel.Id = Travels.Count() + 1;
            Travels.Add(travel);
            coursachEntities.GetContext().SaveChanges();
        }
    }
}
