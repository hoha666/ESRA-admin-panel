using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionViewAngle
    {
        public int IdViewAngleType { get; set; }
        public int IdVersion { get; set; }

        public TblVersion1 IdVersionNavigation { get; set; }
        public TblViewAngleType IdViewAngleTypeNavigation { get; set; }
    }
}
