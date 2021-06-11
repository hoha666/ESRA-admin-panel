using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalyzeReportForm
    {
        public AnalyzeReportForm()
        {
            LowLevelAnalyze2 = new HashSet<LowLevelAnalyze2>();
            UnCategorizedContentForm = new HashSet<UnCategorizedContentForm>();
        }

        public int Id { get; set; }
        public string TxtTime { get; set; }
        public string DdlRadeh { get; set; }
        public string CreatorAnalyzeReportForm { get; set; }
        public string IpAnalyzeReportForm { get; set; }
        public bool? RegistrationStatusAnalyzeReportForm { get; set; }
        public string RegistrationDateAnalyzeReportForm { get; set; }
        public string RegistrationTimeAnalyzeReportForm { get; set; }
        public string AuditStatusAnalyzeReportForm { get; set; }
        public string InstanceIdAnalyzeReportForm { get; set; }
        public int? InstanceSridAnalyzeReportForm { get; set; }

        public ICollection<LowLevelAnalyze2> LowLevelAnalyze2 { get; set; }
        public ICollection<UnCategorizedContentForm> UnCategorizedContentForm { get; set; }
    }
}
