using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblEsra1
    {
        public TblEsra1()
        {
            InverseIdHeadNavigation = new HashSet<TblEsra1>();
            TblVersionEsra1IdEsraNavigation = new HashSet<TblVersionEsra1>();
            TblVersionEsra1IdSystemNavigation = new HashSet<TblVersionEsra1>();
        }

        public int Id { get; set; }
        public string Age { get; set; }
        public int? IdHead { get; set; }

        public TblEsra1 IdHeadNavigation { get; set; }
        public ICollection<TblEsra1> InverseIdHeadNavigation { get; set; }
        public ICollection<TblVersionEsra1> TblVersionEsra1IdEsraNavigation { get; set; }
        public ICollection<TblVersionEsra1> TblVersionEsra1IdSystemNavigation { get; set; }
    }
}
