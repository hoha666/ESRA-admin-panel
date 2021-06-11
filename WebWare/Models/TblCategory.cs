using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            InverseIdParentNavigation = new HashSet<TblCategory>();
            TblVersionGenre = new HashSet<TblVersionGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdParent { get; set; }
        public int IdCategoryType { get; set; }

        public TblCategoryType IdCategoryTypeNavigation { get; set; }
        public TblCategory IdParentNavigation { get; set; }
        public ICollection<TblCategory> InverseIdParentNavigation { get; set; }
        public ICollection<TblVersionGenre> TblVersionGenre { get; set; }
    }
}
