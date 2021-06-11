using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblCategoryType
    {
        public TblCategoryType()
        {
            TblCategory = new HashSet<TblCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblCategory> TblCategory { get; set; }
    }
}
