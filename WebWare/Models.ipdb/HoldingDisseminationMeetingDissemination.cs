using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HoldingDisseminationMeetingDissemination
    {
        public int Id { get; set; }
        public string CreatorHoldingDisseminationMeetingDissemination { get; set; }
        public string IpHoldingDisseminationMeetingDissemination { get; set; }
        public bool? RegistrationStatusHoldingDisseminationMeetingDissemination { get; set; }
        public string RegistrationDateHoldingDisseminationMeetingDissemination { get; set; }
        public string RegistrationTimeHoldingDisseminationMeetingDissemination { get; set; }
        public string AuditStatusHoldingDisseminationMeetingDissemination { get; set; }
        public string InstanceIdHoldingDisseminationMeetingDissemination { get; set; }
        public int? InstanceSridHoldingDisseminationMeetingDissemination { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
