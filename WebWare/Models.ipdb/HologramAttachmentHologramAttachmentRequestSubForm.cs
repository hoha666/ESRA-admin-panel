using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HologramAttachmentHologramAttachmentRequestSubForm
    {
        public int Id { get; set; }
        public int? NumNumberHologramsRequested { get; set; }
        public string CreatorHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public string IpHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public bool? RegistrationStatusHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public string RegistrationDateHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public string RegistrationTimeHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public string AuditStatusHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public string InstanceIdHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public int? InstanceSridHologramAttachmentHologramAttachmentRequestSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public HologramAttachmentHologramAttachmentRequest ParentRecord { get; set; }
    }
}
