using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationSubLevelAnalyzeAnalizorMgntSelection
    {
        public int SubLevelAnalyzeId { get; set; }
        public int AnalizorMgntSelectionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public AnalizorMgntSelection AnalizorMgntSelection { get; set; }
        public SubLevelAnalyze SubLevelAnalyze { get; set; }
    }
}
