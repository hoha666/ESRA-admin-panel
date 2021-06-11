using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblCategoryType
    {
        public TblCategoryType()
        {
            TblCategory1 = new HashSet<TblCategory1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblCategory1> TblCategory1 { get; set; }
    }
}
