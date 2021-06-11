using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class OldHologramGameFinalInstallationListSubForm
    {
        public int Id { get; set; }
        public int? NumHologramAttached { get; set; }
        public int? NumRemainingHologram { get; set; }
        public string DdlReasonForNotAttaching { get; set; }
        public string CreatorOldHologramGameFinalInstallationListSubForm { get; set; }
        public string IpOldHologramGameFinalInstallationListSubForm { get; set; }
        public bool? RegistrationStatusOldHologramGameFinalInstallationListSubForm { get; set; }
        public string RegistrationDateOldHologramGameFinalInstallationListSubForm { get; set; }
        public string RegistrationTimeOldHologramGameFinalInstallationListSubForm { get; set; }
        public string AuditStatusOldHologramGameFinalInstallationListSubForm { get; set; }
        public string InstanceIdOldHologramGameFinalInstallationListSubForm { get; set; }
        public int? InstanceSridOldHologramGameFinalInstallationListSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
