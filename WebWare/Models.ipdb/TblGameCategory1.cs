using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblGameCategory1
    {
        public TblGameCategory1()
        {
            TblVersionCategory1 = new HashSet<TblVersionCategory1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblVersionCategory1> TblVersionCategory1 { get; set; }
    }
}
