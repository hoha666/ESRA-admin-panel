using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwInstances
    {
        public WfwInstances()
        {
            WfwInstanceStates = new HashSet<WfwInstanceStates>();
        }

        public int Id { get; set; }
        public int RecordId { get; set; }
        public DateTime RegTime { get; set; }
        public int WorkFlowDetailId { get; set; }
        public string Status { get; set; }
        public string TrackingCode { get; set; }
        public string Title { get; set; }
        public int ProgressBarStatus { get; set; }
        public bool IsActive { get; set; }
        public bool IsShow { get; set; }

        public WorkFlowDetails WorkFlowDetail { get; set; }
        public ICollection<WfwInstanceStates> WfwInstanceStates { get; set; }
    }
}
