using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwInstanceStates
    {
        public WfwInstanceStates()
        {
            WfwInstanceStateReceivers = new HashSet<WfwInstanceStateReceivers>();
        }

        public int Id { get; set; }
        public int WfwInstanceId { get; set; }
        public DateTime RegDate { get; set; }
        public int NodeDetailId { get; set; }
        public bool IsDone { get; set; }
        public string Result { get; set; }

        public WfwInstances WfwInstance { get; set; }
        public ICollection<WfwInstanceStateReceivers> WfwInstanceStateReceivers { get; set; }
    }
}
