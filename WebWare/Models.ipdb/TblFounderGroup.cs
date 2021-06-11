using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblFounderGroup
    {
        public int IdOrganizationBonyad { get; set; }
        public int IdUser { get; set; }

        public TblOrganizationBonyad IdOrganizationBonyadNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
    }
}
