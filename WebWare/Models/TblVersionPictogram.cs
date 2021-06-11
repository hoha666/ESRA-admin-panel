using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblVersionPictogram
    {
        public int IdVersion { get; set; }
        public int IdPictogram { get; set; }
        public int IdUser { get; set; }
        public bool IsSuggestion { get; set; }
        public int IdRate { get; set; }

        public TblPictogram IdPictogramNavigation { get; set; }
        public TblVersion IdVersionNavigation { get; set; }
    }
}
