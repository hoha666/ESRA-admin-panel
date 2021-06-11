using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HologramAttachmentHologramAttachmentRequest
    {
        public HologramAttachmentHologramAttachmentRequest()
        {
            HologramAttachmentHologramAttachmentRequestSubForm = new HashSet<HologramAttachmentHologramAttachmentRequestSubForm>();
        }

        public int Id { get; set; }
        public string CreatorHologramAttachmentHologramAttachmentRequest { get; set; }
        public string IpHologramAttachmentHologramAttachmentRequest { get; set; }
        public bool? RegistrationStatusHologramAttachmentHologramAttachmentRequest { get; set; }
        public string RegistrationDateHologramAttachmentHologramAttachmentRequest { get; set; }
        public string RegistrationTimeHologramAttachmentHologramAttachmentRequest { get; set; }
        public string AuditStatusHologramAttachmentHologramAttachmentRequest { get; set; }
        public string InstanceIdHologramAttachmentHologramAttachmentRequest { get; set; }
        public int? InstanceSridHologramAttachmentHologramAttachmentRequest { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<HologramAttachmentHologramAttachmentRequestSubForm> HologramAttachmentHologramAttachmentRequestSubForm { get; set; }
    }
}
