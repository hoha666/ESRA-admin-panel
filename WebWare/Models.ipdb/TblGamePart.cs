using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblGamePart
    {
        public TblGamePart()
        {
            TblAnalizGamePart = new HashSet<TblAnalizGamePart>();
            TblVersionAnaliz = new HashSet<TblVersionAnaliz>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblAnalizGamePart> TblAnalizGamePart { get; set; }
        public ICollection<TblVersionAnaliz> TblVersionAnaliz { get; set; }
    }
}
