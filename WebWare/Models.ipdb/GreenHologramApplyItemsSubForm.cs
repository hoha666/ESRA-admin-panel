using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramApplyItemsSubForm
    {
        public int Id { get; set; }
        public int? NumNumberHolograms { get; set; }
        public string CreatorGreenHologramApplyItemsSubForm { get; set; }
        public string IpGreenHologramApplyItemsSubForm { get; set; }
        public bool? RegistrationStatusGreenHologramApplyItemsSubForm { get; set; }
        public string RegistrationDateGreenHologramApplyItemsSubForm { get; set; }
        public string RegistrationTimeGreenHologramApplyItemsSubForm { get; set; }
        public string AuditStatusGreenHologramApplyItemsSubForm { get; set; }
        public string InstanceIdGreenHologramApplyItemsSubForm { get; set; }
        public int? InstanceSridGreenHologramApplyItemsSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public GreenHologramApplyItems ParentRecord { get; set; }
    }
}
