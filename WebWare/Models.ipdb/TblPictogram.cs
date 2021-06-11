using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPictogram
    {
        public TblPictogram()
        {
            InverseIdHeadNavigation = new HashSet<TblPictogram>();
            TblVersionPictogram1 = new HashSet<TblVersionPictogram1>();
        }

        public int Id { get; set; }
        public int? IdHead { get; set; }
        public string Name { get; set; }
        public bool? Type { get; set; }

        public TblPictogram IdHeadNavigation { get; set; }
        public ICollection<TblPictogram> InverseIdHeadNavigation { get; set; }
        public ICollection<TblVersionPictogram1> TblVersionPictogram1 { get; set; }
    }
}
