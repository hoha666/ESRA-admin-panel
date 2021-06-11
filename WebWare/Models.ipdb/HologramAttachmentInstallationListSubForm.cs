using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HologramAttachmentInstallationListSubForm
    {
        public int Id { get; set; }
        public int? NumNumberHologramsAttached { get; set; }
        public string CreatorHologramAttachmentInstallationListSubForm { get; set; }
        public string IpHologramAttachmentInstallationListSubForm { get; set; }
        public bool? RegistrationStatusHologramAttachmentInstallationListSubForm { get; set; }
        public string RegistrationDateHologramAttachmentInstallationListSubForm { get; set; }
        public string RegistrationTimeHologramAttachmentInstallationListSubForm { get; set; }
        public string AuditStatusHologramAttachmentInstallationListSubForm { get; set; }
        public string InstanceIdHologramAttachmentInstallationListSubForm { get; set; }
        public int? InstanceSridHologramAttachmentInstallationListSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public HologramAttachmentInstallationList ParentRecord { get; set; }
    }
}
