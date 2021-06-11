using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwCalculations
    {
        public int Id { get; set; }
        public string Formula { get; set; }

        public NodeDetails IdNavigation { get; set; }
    }
}
