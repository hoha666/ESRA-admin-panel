using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class HoldingDisseminationRecordResults
    {
        public HoldingDisseminationRecordResults()
        {
            HoldingDisseminationRecordResultsSubForm = new HashSet<HoldingDisseminationRecordResultsSubForm>();
        }

        public int Id { get; set; }
        public string PdateMeetingDate { get; set; }
        public DateTime? PdateMeetingDateGregorian { get; set; }
        public string UplUploadMinutes { get; set; }
        public string CreatorHoldingDisseminationRecordResults { get; set; }
        public string IpHoldingDisseminationRecordResults { get; set; }
        public bool? RegistrationStatusHoldingDisseminationRecordResults { get; set; }
        public string RegistrationDateHoldingDisseminationRecordResults { get; set; }
        public string RegistrationTimeHoldingDisseminationRecordResults { get; set; }
        public string AuditStatusHoldingDisseminationRecordResults { get; set; }
        public string InstanceIdHoldingDisseminationRecordResults { get; set; }
        public int? InstanceSridHoldingDisseminationRecordResults { get; set; }

        public ICollection<HoldingDisseminationRecordResultsSubForm> HoldingDisseminationRecordResultsSubForm { get; set; }
    }
}
