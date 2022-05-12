using MyLove.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class MainWindowModel
    {
        private DbSet<Era> eras;
        public MainWindowModel()
        {
            eras = coursachEntities.GetContext().Set<Era>();
        }

        public void AddNewEra(Era era)
        {
            era.Id = eras.Count() + 1;
            eras.Add(era);
            coursachEntities.GetContext().SaveChanges();
        }
    }
}
