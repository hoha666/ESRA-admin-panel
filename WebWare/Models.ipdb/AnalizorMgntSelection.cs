using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalizorMgntSelection
    {
        public AnalizorMgntSelection()
        {
            RelationSubLevelAnalyzeAnalizorMgntSelection = new HashSet<RelationSubLevelAnalyzeAnalizorMgntSelection>();
        }

        public int Id { get; set; }
        public string FileUpload { get; set; }
        public string TxaComment { get; set; }
        public string CreatorAnalizorMgntSelection { get; set; }
        public string IpAnalizorMgntSelection { get; set; }
        public bool? RegistrationStatusAnalizorMgntSelection { get; set; }
        public string RegistrationDateAnalizorMgntSelection { get; set; }
        public string RegistrationTimeAnalizorMgntSelection { get; set; }
        public string AuditStatusAnalizorMgntSelection { get; set; }
        public string InstanceIdAnalizorMgntSelection { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridAnalizorMgntSelection { get; set; }

        public AnalizorMgntConfirmation ParentRecord { get; set; }
        public ICollection<RelationSubLevelAnalyzeAnalizorMgntSelection> RelationSubLevelAnalyzeAnalizorMgntSelection { get; set; }
    }
}
