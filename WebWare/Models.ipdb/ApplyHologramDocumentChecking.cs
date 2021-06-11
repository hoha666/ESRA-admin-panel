using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ApplyHologramDocumentChecking
    {
        public int Id { get; set; }
        public string DdlResultReview { get; set; }
        public string AxtNeedCorrection { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorApplyHologramDocumentChecking { get; set; }
        public string IpApplyHologramDocumentChecking { get; set; }
        public bool? RegistrationStatusApplyHologramDocumentChecking { get; set; }
        public string RegistrationDateApplyHologramDocumentChecking { get; set; }
        public string RegistrationTimeApplyHologramDocumentChecking { get; set; }
        public string AuditStatusApplyHologramDocumentChecking { get; set; }
        public string InstanceIdApplyHologramDocumentChecking { get; set; }
        public int? InstanceSridApplyHologramDocumentChecking { get; set; }
    }
}
