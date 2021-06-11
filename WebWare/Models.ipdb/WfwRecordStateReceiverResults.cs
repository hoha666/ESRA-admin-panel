using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwRecordStateReceiverResults
    {
        public int Id { get; set; }
        public int WfwInstanceStateReceiverId { get; set; }
        public int WfwActionId { get; set; }

        public WfwInstanceStateReceivers WfwInstanceStateReceiver { get; set; }
    }
}
