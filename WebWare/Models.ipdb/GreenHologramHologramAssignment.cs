using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramHologramAssignment
    {
        public int Id { get; set; }
        public string PdateAllocationDate { get; set; }
        public DateTime? PdateAllocationDateGregorian { get; set; }
        public int? NumNumberAssignments { get; set; }
        public int? NumFirstNumber { get; set; }
        public int? NumLastNumber { get; set; }
        public string UplUploadedReceipt { get; set; }
        public string CreatorGreenHologramHologramAssignment { get; set; }
        public string IpGreenHologramHologramAssignment { get; set; }
        public bool? RegistrationStatusGreenHologramHologramAssignment { get; set; }
        public string RegistrationDateGreenHologramHologramAssignment { get; set; }
        public string RegistrationTimeGreenHologramHologramAssignment { get; set; }
        public string AuditStatusGreenHologramHologramAssignment { get; set; }
        public string InstanceIdGreenHologramHologramAssignment { get; set; }
        public int? InstanceSridGreenHologramHologramAssignment { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
