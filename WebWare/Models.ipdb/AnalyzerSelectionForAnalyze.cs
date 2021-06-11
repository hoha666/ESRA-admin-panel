using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalyzerSelectionForAnalyze
    {
        public int Id { get; set; }
        public string DdlAnalSelect { get; set; }
        public string CreatorAnalyzerSelectionForAnalyze { get; set; }
        public string IpAnalyzerSelectionForAnalyze { get; set; }
        public bool? RegistrationStatusAnalyzerSelectionForAnalyze { get; set; }
        public string RegistrationDateAnalyzerSelectionForAnalyze { get; set; }
        public string RegistrationTimeAnalyzerSelectionForAnalyze { get; set; }
        public string AuditStatusAnalyzerSelectionForAnalyze { get; set; }
        public string InstanceIdAnalyzerSelectionForAnalyze { get; set; }
        public int? InstanceSridAnalyzerSelectionForAnalyze { get; set; }
    }
}
