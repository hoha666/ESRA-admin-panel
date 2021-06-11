using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionExclusive
    {
        public int IdVersion { get; set; }
        public int IdExclusive { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool HolderType { get; set; }

        public TblProducerNexclusiveNuser IdExclusiveNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
