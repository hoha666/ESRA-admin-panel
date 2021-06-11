using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblOrganizationBonyadFile
    {
        public int IdOrganizationBonyad { get; set; }
        public int IdFile { get; set; }
        public int IdIdentificationType { get; set; }
        public string Comment { get; set; }

        public TblFile1 IdFileNavigation { get; set; }
        public TblIdentificationType IdIdentificationTypeNavigation { get; set; }
        public TblOrganizationBonyad IdOrganizationBonyadNavigation { get; set; }
    }
}
