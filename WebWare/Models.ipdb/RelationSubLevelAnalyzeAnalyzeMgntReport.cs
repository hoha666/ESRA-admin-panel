using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationSubLevelAnalyzeAnalyzeMgntReport
    {
        public int Id { get; set; }
        public int? AnalyzeMgntReportId { get; set; }
        public int? SubLevelAnalyzeId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
