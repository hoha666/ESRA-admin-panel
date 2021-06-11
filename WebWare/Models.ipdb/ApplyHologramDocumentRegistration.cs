using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ApplyHologramDocumentRegistration
    {
        public int Id { get; set; }
        public int? NumAddedNumberHolograms { get; set; }
        public string DdlGetPhysicalReceipt { get; set; }
        public string UplDocumentImages { get; set; }
        public string CreatorApplyHologramDocumentRegistration { get; set; }
        public string IpApplyHologramDocumentRegistration { get; set; }
        public bool? RegistrationStatusApplyHologramDocumentRegistration { get; set; }
        public string RegistrationDateApplyHologramDocumentRegistration { get; set; }
        public string RegistrationTimeApplyHologramDocumentRegistration { get; set; }
        public string AuditStatusApplyHologramDocumentRegistration { get; set; }
        public string InstanceIdApplyHologramDocumentRegistration { get; set; }
        public int? InstanceSridApplyHologramDocumentRegistration { get; set; }
    }
}
