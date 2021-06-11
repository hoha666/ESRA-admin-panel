using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwInstanceStateReceivers
    {
        public WfwInstanceStateReceivers()
        {
            CartableLetters = new HashSet<CartableLetters>();
            WfwRecordStateReceiverResults = new HashSet<WfwRecordStateReceiverResults>();
        }

        public int Id { get; set; }
        public int WfwInstanceStateId { get; set; }
        public int ReceiverActiveUserId { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime? ViewDate { get; set; }
        public DateTime? DoDate { get; set; }
        public bool IsRejected { get; set; }
        public string Action { get; set; }

        public WfwInstanceStates WfwInstanceState { get; set; }
        public ICollection<CartableLetters> CartableLetters { get; set; }
        public ICollection<WfwRecordStateReceiverResults> WfwRecordStateReceiverResults { get; set; }
    }
}
