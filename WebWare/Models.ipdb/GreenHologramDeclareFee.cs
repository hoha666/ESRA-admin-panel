using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramDeclareFee
    {
        public int Id { get; set; }
        public int? NumFeeRequested { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorGreenHologramDeclareFee { get; set; }
        public string IpGreenHologramDeclareFee { get; set; }
        public bool? RegistrationStatusGreenHologramDeclareFee { get; set; }
        public string RegistrationDateGreenHologramDeclareFee { get; set; }
        public string RegistrationTimeGreenHologramDeclareFee { get; set; }
        public string AuditStatusGreenHologramDeclareFee { get; set; }
        public string InstanceIdGreenHologramDeclareFee { get; set; }
        public int? InstanceSridGreenHologramDeclareFee { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
