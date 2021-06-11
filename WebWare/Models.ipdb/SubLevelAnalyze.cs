using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubLevelAnalyze
    {
        public SubLevelAnalyze()
        {
            RelationSubLevelAnalyzeAnalizorMgntSelection = new HashSet<RelationSubLevelAnalyzeAnalizorMgntSelection>();
        }

        public int Id { get; set; }
        public string TxtFileName { get; set; }
        public string ContentTime { get; set; }
        public string TxtImpact { get; set; }
        public string TxtContentSource { get; set; }
        public string TxaComment { get; set; }
        public string FileUpload { get; set; }
        public string CreatorSubLevelAnalyze { get; set; }
        public string IpSubLevelAnalyze { get; set; }
        public bool? RegistrationStatusSubLevelAnalyze { get; set; }
        public string RegistrationDateSubLevelAnalyze { get; set; }
        public string RegistrationTimeSubLevelAnalyze { get; set; }
        public string AuditStatusSubLevelAnalyze { get; set; }
        public string InstanceIdSubLevelAnalyze { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridSubLevelAnalyze { get; set; }
        public string DdlLevel1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }

        public AnalyzerReport ParentRecord { get; set; }
        public ICollection<RelationSubLevelAnalyzeAnalizorMgntSelection> RelationSubLevelAnalyzeAnalizorMgntSelection { get; set; }
    }
}
