using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAreaActivity
    {
        public TblAreaActivity()
        {
            TblCompanyAriaActivity = new HashSet<TblCompanyAriaActivity>();
            TblGameCreatorProjects = new HashSet<TblGameCreatorProjects>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? InBonyad { get; set; }

        public ICollection<TblCompanyAriaActivity> TblCompanyAriaActivity { get; set; }
        public ICollection<TblGameCreatorProjects> TblGameCreatorProjects { get; set; }
    }
}
