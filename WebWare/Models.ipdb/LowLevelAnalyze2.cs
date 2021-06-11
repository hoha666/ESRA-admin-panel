using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class LowLevelAnalyze2
    {
        public int Id { get; set; }
        public string DdlL1 { get; set; }
        public string DdlL2 { get; set; }
        public string DdlL3 { get; set; }
        public string CreatorLowLevelAnalyze2 { get; set; }
        public string IpLowLevelAnalyze2 { get; set; }
        public bool? RegistrationStatusLowLevelAnalyze2 { get; set; }
        public string RegistrationDateLowLevelAnalyze2 { get; set; }
        public string RegistrationTimeLowLevelAnalyze2 { get; set; }
        public string AuditStatusLowLevelAnalyze2 { get; set; }
        public string InstanceIdLowLevelAnalyze2 { get; set; }
        public int? InstanceSridLowLevelAnalyze2 { get; set; }
        public string TxtCt { get; set; }
        public string DdlEfect { get; set; }
        public string DdlContentRoot { get; set; }
        public string UplFilm { get; set; }
        public string TxtCtime { get; set; }
        public string TxaTozih { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public AnalyzeReportForm ParentRecord { get; set; }
    }
}
