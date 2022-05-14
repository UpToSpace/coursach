using MyLove.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class NewModel
    {
        private DbSet<Era> eras;
        public NewModel()
        {
            eras = coursachEntities.GetContext().Set<Era>();
        }

        public void AddNewEra(Era era)
        {
            era.Id = eras.Count() == 0 ? 1 : eras.ToList().Last().Id + 1;
            eras.Add(era);
            coursachEntities.GetContext().SaveChanges();
        }
    }
}
