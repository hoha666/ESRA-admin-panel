using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HoldingDisseminationRecordResultsSubForm
    {
        public int Id { get; set; }
        public string DdlItemName { get; set; }
        public string DdlNameAndIdpublisher { get; set; }
        public int? NumNumberHologramsRecorded { get; set; }
        public string CreatorHoldingDisseminationRecordResultsSubForm { get; set; }
        public string IpHoldingDisseminationRecordResultsSubForm { get; set; }
        public bool? RegistrationStatusHoldingDisseminationRecordResultsSubForm { get; set; }
        public string RegistrationDateHoldingDisseminationRecordResultsSubForm { get; set; }
        public string RegistrationTimeHoldingDisseminationRecordResultsSubForm { get; set; }
        public string AuditStatusHoldingDisseminationRecordResultsSubForm { get; set; }
        public string InstanceIdHoldingDisseminationRecordResultsSubForm { get; set; }
        public int? InstanceSridHoldingDisseminationRecordResultsSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public HoldingDisseminationRecordResults ParentRecord { get; set; }
    }
}
