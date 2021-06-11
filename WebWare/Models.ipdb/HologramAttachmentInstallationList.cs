using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HologramAttachmentInstallationList
    {
        public HologramAttachmentInstallationList()
        {
            HologramAttachmentInstallationListSubForm = new HashSet<HologramAttachmentInstallationListSubForm>();
        }

        public int Id { get; set; }
        public string AxtDescription { get; set; }
        public string UplUploadDocumentation { get; set; }
        public string CreatorHologramAttachmentInstallationList { get; set; }
        public string IpHologramAttachmentInstallationList { get; set; }
        public bool? RegistrationStatusHologramAttachmentInstallationList { get; set; }
        public string RegistrationDateHologramAttachmentInstallationList { get; set; }
        public string RegistrationTimeHologramAttachmentInstallationList { get; set; }
        public string AuditStatusHologramAttachmentInstallationList { get; set; }
        public string InstanceIdHologramAttachmentInstallationList { get; set; }
        public int? InstanceSridHologramAttachmentInstallationList { get; set; }

        public ICollection<HologramAttachmentInstallationListSubForm> HologramAttachmentInstallationListSubForm { get; set; }
    }
}
