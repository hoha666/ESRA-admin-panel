using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblGameCategory
    {
        public TblGameCategory()
        {
            TblVersionCategory = new HashSet<TblVersionCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblVersionCategory> TblVersionCategory { get; set; }
    }
}
