using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionPictogram
    {
        public int IdVersion { get; set; }
        public int IdPictogram { get; set; }
        public int IdUser { get; set; }
        public bool IsSuggestion { get; set; }
        public int IdRate { get; set; }

        public TblPictogram1 IdPictogramNavigation { get; set; }
        public TblRate IdRateNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
