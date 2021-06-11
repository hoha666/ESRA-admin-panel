using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorkFlowStartEnds
    {
        public int Id { get; set; }
        public bool Type { get; set; }
        public string Description { get; set; }

        public NodeDetails IdNavigation { get; set; }
    }
}
