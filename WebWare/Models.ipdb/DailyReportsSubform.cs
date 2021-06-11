using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DailyReportsSubform
    {
        public int Id { get; set; }
        public string TastTitle { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string TxaComment { get; set; }
        public string CreatorDailyReportsSubform { get; set; }
        public string IpDailyReportsSubform { get; set; }
        public bool? RegistrationStatusDailyReportsSubform { get; set; }
        public string RegistrationDateDailyReportsSubform { get; set; }
        public string RegistrationTimeDailyReportsSubform { get; set; }
        public string AuditStatusDailyReportsSubform { get; set; }
        public string InstanceIdDailyReportsSubform { get; set; }
        public int? InstanceSridDailyReportsSubform { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public DailyTimeSheet ParentRecord { get; set; }
    }
}
