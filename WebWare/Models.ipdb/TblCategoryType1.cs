using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblCategoryType1
    {
        public TblCategoryType1()
        {
            TblCategory = new HashSet<TblCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblCategory> TblCategory { get; set; }
    }
}
