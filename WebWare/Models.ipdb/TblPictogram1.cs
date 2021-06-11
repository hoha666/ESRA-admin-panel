using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPictogram1
    {
        public TblPictogram1()
        {
            InverseIdHeadNavigation = new HashSet<TblPictogram1>();
            TblGamerScreenVideo = new HashSet<TblGamerScreenVideo>();
            TblVersionAnaliz = new HashSet<TblVersionAnaliz>();
            TblVersionPictogram = new HashSet<TblVersionPictogram>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Type { get; set; }
        public int? IdHead { get; set; }

        public TblPictogram1 IdHeadNavigation { get; set; }
        public ICollection<TblPictogram1> InverseIdHeadNavigation { get; set; }
        public ICollection<TblGamerScreenVideo> TblGamerScreenVideo { get; set; }
        public ICollection<TblVersionAnaliz> TblVersionAnaliz { get; set; }
        public ICollection<TblVersionPictogram> TblVersionPictogram { get; set; }
    }
}
