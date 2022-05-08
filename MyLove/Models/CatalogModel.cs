using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLove.Models
{
    class CatalogModel
    {
        private IEnumerable<Era> eras;
        public IEnumerable<Era> Eras { get => eras; set => eras = value; }

        public CatalogModel()
        {
            Eras = coursachEntities.GetContext().Era;
        }

    }
}
