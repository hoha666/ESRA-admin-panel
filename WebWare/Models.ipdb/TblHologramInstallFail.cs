using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblHologramInstallFail
    {
        public int IdhologramInstalition { get; set; }
        public int IdFailReason { get; set; }

        public TblDeficiencyType IdFailReasonNavigation { get; set; }
        public TblHologramInstalltion IdhologramInstalitionNavigation { get; set; }
    }
}
