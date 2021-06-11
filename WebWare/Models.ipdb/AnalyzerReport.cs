using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalyzerReport
    {
        public AnalyzerReport()
        {
            SubLevelAnalyze = new HashSet<SubLevelAnalyze>();
            UnclassifiedContent = new HashSet<UnclassifiedContent>();
        }

        public int Id { get; set; }
        public string AnalyzeTime { get; set; }
        public string TxtAgeRating { get; set; }
        public string CreatorAnalyzerReport { get; set; }
        public string IpAnalyzerReport { get; set; }
        public bool? RegistrationStatusAnalyzerReport { get; set; }
        public string RegistrationDateAnalyzerReport { get; set; }
        public string RegistrationTimeAnalyzerReport { get; set; }
        public string AuditStatusAnalyzerReport { get; set; }
        public string InstanceIdAnalyzerReport { get; set; }
        public int? InstanceSridAnalyzerReport { get; set; }
        public string TxaComment { get; set; }

        public ICollection<SubLevelAnalyze> SubLevelAnalyze { get; set; }
        public ICollection<UnclassifiedContent> UnclassifiedContent { get; set; }
    }
}
