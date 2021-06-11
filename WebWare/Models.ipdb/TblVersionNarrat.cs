using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionNarrat
    {
        public int IdVersion { get; set; }
        public string NarratorSummary { get; set; }
        public string NarratorStory { get; set; }
        public string NarratorMetacritic { get; set; }

        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
