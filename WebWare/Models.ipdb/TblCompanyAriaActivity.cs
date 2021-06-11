using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblCompanyAriaActivity
    {
        public int IdAriaActivity { get; set; }
        public int IdOrganizationBonyad { get; set; }
        public bool InBonyad { get; set; }

        public TblAreaActivity IdAriaActivityNavigation { get; set; }
        public TblOrganizationBonyad IdOrganizationBonyadNavigation { get; set; }
    }
}
