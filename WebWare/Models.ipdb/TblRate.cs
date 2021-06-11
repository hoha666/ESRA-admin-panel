using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblRate
    {
        public TblRate()
        {
            TblVersionAnaliz = new HashSet<TblVersionAnaliz>();
            TblVersionPictogram = new HashSet<TblVersionPictogram>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdHead { get; set; }

        public ICollection<TblVersionAnaliz> TblVersionAnaliz { get; set; }
        public ICollection<TblVersionPictogram> TblVersionPictogram { get; set; }
    }
}
