using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramApplyItems
    {
        public GreenHologramApplyItems()
        {
            GreenHologramApplyItemsSubForm = new HashSet<GreenHologramApplyItemsSubForm>();
        }

        public int Id { get; set; }
        public string CreatorGreenHologramApplyItems { get; set; }
        public string IpGreenHologramApplyItems { get; set; }
        public bool? RegistrationStatusGreenHologramApplyItems { get; set; }
        public string RegistrationDateGreenHologramApplyItems { get; set; }
        public string RegistrationTimeGreenHologramApplyItems { get; set; }
        public string AuditStatusGreenHologramApplyItems { get; set; }
        public string InstanceIdGreenHologramApplyItems { get; set; }
        public int? InstanceSridGreenHologramApplyItems { get; set; }
        public string AxtDescription { get; set; }
        public string TxtRequestTitle { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<GreenHologramApplyItemsSubForm> GreenHologramApplyItemsSubForm { get; set; }
    }
}
