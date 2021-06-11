using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblCategory1
    {
        public TblCategory1()
        {
            InverseIdParentNavigation = new HashSet<TblCategory1>();
            TblVersionGenre = new HashSet<TblVersionGenre>();
        }

        public int Id { get; set; }
        public int IdCategoryType { get; set; }
        public int? IdParent { get; set; }
        public string Name { get; set; }

        public TblCategoryType IdCategoryTypeNavigation { get; set; }
        public TblCategory1 IdParentNavigation { get; set; }
        public ICollection<TblCategory1> InverseIdParentNavigation { get; set; }
        public ICollection<TblVersionGenre> TblVersionGenre { get; set; }
    }
}
