using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramRecordRemaining
    {
        public int Id { get; set; }
        public string PdateDateReceived { get; set; }
        public DateTime? PdateDateReceivedGregorian { get; set; }
        public int? NumRemainingHologram { get; set; }
        public int? NumFirstNumber { get; set; }
        public int? NumLastNumber { get; set; }
        public string CreatorGreenHologramRecordRemaining { get; set; }
        public string IpGreenHologramRecordRemaining { get; set; }
        public bool? RegistrationStatusGreenHologramRecordRemaining { get; set; }
        public string RegistrationDateGreenHologramRecordRemaining { get; set; }
        public string RegistrationTimeGreenHologramRecordRemaining { get; set; }
        public string AuditStatusGreenHologramRecordRemaining { get; set; }
        public string InstanceIdGreenHologramRecordRemaining { get; set; }
        public int? InstanceSridGreenHologramRecordRemaining { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
