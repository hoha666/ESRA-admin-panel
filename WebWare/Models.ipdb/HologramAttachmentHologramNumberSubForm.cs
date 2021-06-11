using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HologramAttachmentHologramNumberSubForm
    {
        public int Id { get; set; }
        public int? NumNumberFirstHologram { get; set; }
        public int? NumNumberLastHologram { get; set; }
        public string CreatorHologramAttachmentHologramNumberSubForm { get; set; }
        public string IpHologramAttachmentHologramNumberSubForm { get; set; }
        public bool? RegistrationStatusHologramAttachmentHologramNumberSubForm { get; set; }
        public string RegistrationDateHologramAttachmentHologramNumberSubForm { get; set; }
        public string RegistrationTimeHologramAttachmentHologramNumberSubForm { get; set; }
        public string AuditStatusHologramAttachmentHologramNumberSubForm { get; set; }
        public string InstanceIdHologramAttachmentHologramNumberSubForm { get; set; }
        public int? InstanceSridHologramAttachmentHologramNumberSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public HologramAttachmentHologramNumber ParentRecord { get; set; }
    }
}
