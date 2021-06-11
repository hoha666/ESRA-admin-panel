using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramAttachmentDocumentation
    {
        public int Id { get; set; }
        public string PdateAttachDate { get; set; }
        public DateTime? PdateAttachDateGregorian { get; set; }
        public int? NumHologramAttached { get; set; }
        public int? NumHologramRemaining { get; set; }
        public string DdlReasonNotAttaching { get; set; }
        public string UplUploadForm { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorGreenHologramAttachmentDocumentation { get; set; }
        public string IpGreenHologramAttachmentDocumentation { get; set; }
        public bool? RegistrationStatusGreenHologramAttachmentDocumentation { get; set; }
        public string RegistrationDateGreenHologramAttachmentDocumentation { get; set; }
        public string RegistrationTimeGreenHologramAttachmentDocumentation { get; set; }
        public string AuditStatusGreenHologramAttachmentDocumentation { get; set; }
        public string InstanceIdGreenHologramAttachmentDocumentation { get; set; }
        public int? InstanceSridGreenHologramAttachmentDocumentation { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
