using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblEsra
    {
        public TblEsra()
        {
            InverseIdHeadNavigation = new HashSet<TblEsra>();
            TblVersionEsraIdEsraNavigation = new HashSet<TblVersionEsra>();
            TblVersionEsraIdSystemNavigation = new HashSet<TblVersionEsra>();
        }

        public int Id { get; set; }
        public string Age { get; set; }
        public int? IdHead { get; set; }

        public TblEsra IdHeadNavigation { get; set; }
        public ICollection<TblEsra> InverseIdHeadNavigation { get; set; }
        public ICollection<TblVersionEsra> TblVersionEsraIdEsraNavigation { get; set; }
        public ICollection<TblVersionEsra> TblVersionEsraIdSystemNavigation { get; set; }
    }
}
