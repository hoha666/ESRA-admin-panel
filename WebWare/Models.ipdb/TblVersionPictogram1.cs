using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionPictogram1
    {
        public int IdVersion { get; set; }
        public int IdPictogram { get; set; }
        public int IdUser { get; set; }
        public int IdRate { get; set; }
        public bool IsSuggestion { get; set; }

        public TblPictogram IdPictogramNavigation { get; set; }
        public TblVersion IdVersionNavigation { get; set; }
    }
}
