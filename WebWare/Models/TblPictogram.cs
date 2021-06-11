using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblPictogram
    {
        public TblPictogram()
        {
            InverseIdHeadNavigation = new HashSet<TblPictogram>();
            TblVersionPictogram = new HashSet<TblVersionPictogram>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Type { get; set; }
        public int? IdHead { get; set; }

        public TblPictogram IdHeadNavigation { get; set; }
        public ICollection<TblPictogram> InverseIdHeadNavigation { get; set; }
        public ICollection<TblVersionPictogram> TblVersionPictogram { get; set; }
    }
}
