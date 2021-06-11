using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DailyTimeSheet
    {
        public DailyTimeSheet()
        {
            DailyReportsSubform = new HashSet<DailyReportsSubform>();
        }

        public int Id { get; set; }
        public string Date { get; set; }
        public string CreatorDailyTimeSheet { get; set; }
        public string IpDailyTimeSheet { get; set; }
        public bool? RegistrationStatusDailyTimeSheet { get; set; }
        public string RegistrationDateDailyTimeSheet { get; set; }
        public string RegistrationTimeDailyTimeSheet { get; set; }
        public string AuditStatusDailyTimeSheet { get; set; }
        public string InstanceIdDailyTimeSheet { get; set; }
        public int? InstanceSridDailyTimeSheet { get; set; }

        public ICollection<DailyReportsSubform> DailyReportsSubform { get; set; }
    }
}
