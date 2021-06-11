using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblLanguage
    {
        public TblLanguage()
        {
            TblVersion1 = new HashSet<TblVersion1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LocalName { get; set; }

        public ICollection<TblVersion1> TblVersion1 { get; set; }
    }
}
