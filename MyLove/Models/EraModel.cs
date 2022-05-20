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
            if (!Travels.Where(e => e.Username == travel.Username && e.EraId == travel.EraId).Any())
            {
                travel.Id = Travels.Count() == 0 ? 1 : Travels.ToList().Last().Id + 1;
                Travels.Add(travel);
                coursachEntities.GetContext().SaveChanges();
            }
        }
    }
}
