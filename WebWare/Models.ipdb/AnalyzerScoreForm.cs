using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalyzerScoreForm
    {
        public int Id { get; set; }
        public string DdlFear { get; set; }
        public string DdlFight { get; set; }
        public string DdlAnom { get; set; }
        public string DdlDokhan { get; set; }
        public string DdlNoHope { get; set; }
        public string CreatorAnalyzerScoreForm { get; set; }
        public string IpAnalyzerScoreForm { get; set; }
        public bool? RegistrationStatusAnalyzerScoreForm { get; set; }
        public string RegistrationDateAnalyzerScoreForm { get; set; }
        public string RegistrationTimeAnalyzerScoreForm { get; set; }
        public string AuditStatusAnalyzerScoreForm { get; set; }
        public string InstanceIdAnalyzerScoreForm { get; set; }
        public int? InstanceSridAnalyzerScoreForm { get; set; }
    }
}
