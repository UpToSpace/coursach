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

        public CatalogModel()
        {
            eras = coursachEntities.GetContext().Era;
        }

    }
}
