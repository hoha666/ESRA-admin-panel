using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            InverseIdParentNavigation = new HashSet<TblCategory>();
            TblVersionGenre1 = new HashSet<TblVersionGenre1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdParent { get; set; }
        public int IdCategoryType { get; set; }

        public TblCategoryType1 IdCategoryTypeNavigation { get; set; }
        public TblCategory IdParentNavigation { get; set; }
        public ICollection<TblCategory> InverseIdParentNavigation { get; set; }
        public ICollection<TblVersionGenre1> TblVersionGenre1 { get; set; }
    }
}
