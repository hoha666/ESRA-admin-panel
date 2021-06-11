using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwDecisions
    {
        public WfwDecisions()
        {
            WfwOperations = new HashSet<WfwOperations>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public NodeDetails IdNavigation { get; set; }
        public ICollection<WfwOperations> WfwOperations { get; set; }
    }
}
