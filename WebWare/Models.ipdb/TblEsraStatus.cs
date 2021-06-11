using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblEsraStatus
    {
        public TblEsraStatus()
        {
            TblVersionEsra1 = new HashSet<TblVersionEsra1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblVersionEsra1> TblVersionEsra1 { get; set; }
    }
}
