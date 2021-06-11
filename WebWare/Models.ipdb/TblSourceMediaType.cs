using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblSourceMediaType
    {
        public TblSourceMediaType()
        {
            TblSourceMedia = new HashSet<TblSourceMedia>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblSourceMedia> TblSourceMedia { get; set; }
    }
}
