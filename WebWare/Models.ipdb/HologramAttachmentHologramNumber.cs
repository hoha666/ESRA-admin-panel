using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HologramAttachmentHologramNumber
    {
        public HologramAttachmentHologramNumber()
        {
            HologramAttachmentHologramNumberSubForm = new HashSet<HologramAttachmentHologramNumberSubForm>();
        }

        public int Id { get; set; }
        public string CreatorHologramAttachmentHologramNumber { get; set; }
        public string IpHologramAttachmentHologramNumber { get; set; }
        public bool? RegistrationStatusHologramAttachmentHologramNumber { get; set; }
        public string RegistrationDateHologramAttachmentHologramNumber { get; set; }
        public string RegistrationTimeHologramAttachmentHologramNumber { get; set; }
        public string AuditStatusHologramAttachmentHologramNumber { get; set; }
        public string InstanceIdHologramAttachmentHologramNumber { get; set; }
        public int? InstanceSridHologramAttachmentHologramNumber { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<HologramAttachmentHologramNumberSubForm> HologramAttachmentHologramNumberSubForm { get; set; }
    }
}
