using MyLove.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class CatalogModel
    {
        private DbSet<Era> eras;
        private DbSet<Travel> travels;
        public DbSet<Era> Eras { get => eras; set => eras = value; }

        public CatalogModel()
        {
            Eras = coursachEntities.GetContext().Set<Era>();
        }

        public void DeleteEra(Era era)
        {
            travels = coursachEntities.GetContext().Set<Travel>();
            foreach (var item in travels)
            {
                if (item.Era == era)
                {
                    travels.Remove(item);
                }
            }
            Eras.Remove(era);
            coursachEntities.GetContext().SaveChanges();
        }
    }
}
