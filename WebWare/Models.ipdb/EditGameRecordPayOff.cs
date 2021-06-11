using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EditGameRecordPayOff
    {
        public int Id { get; set; }
        public string DdlPerformSettlementByPublisher { get; set; }
        public string UplLayoutDocumentation { get; set; }
        public string PdatePerformSettlementByPublisher { get; set; }
        public DateTime? PdatePerformSettlementByPublisherGregorian { get; set; }
        public string CreatorEditGameRecordPayOff { get; set; }
        public string IpEditGameRecordPayOff { get; set; }
        public bool? RegistrationStatusEditGameRecordPayOff { get; set; }
        public string RegistrationDateEditGameRecordPayOff { get; set; }
        public string RegistrationTimeEditGameRecordPayOff { get; set; }
        public string AuditStatusEditGameRecordPayOff { get; set; }
        public string InstanceIdEditGameRecordPayOff { get; set; }
        public int? InstanceSridEditGameRecordPayOff { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
