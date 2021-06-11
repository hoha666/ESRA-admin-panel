using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorkFlowProgresses
    {
        public WorkFlowProgresses()
        {
            WfProgressDetails = new HashSet<WfProgressDetails>();
            WorkFlowDetails = new HashSet<WorkFlowDetails>();
        }

        public int Id { get; set; }
        public int WorkFlowId { get; set; }
        public int NodeId { get; set; }
        public int Priority { get; set; }
        public bool ShowInProgressbar { get; set; }

        public ICollection<WfProgressDetails> WfProgressDetails { get; set; }
        public ICollection<WorkFlowDetails> WorkFlowDetails { get; set; }
    }
}
