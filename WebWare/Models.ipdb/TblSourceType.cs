using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblSourceType
    {
        public TblSourceType()
        {
            TblVersion = new HashSet<TblVersion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblVersion> TblVersion { get; set; }
    }
}
