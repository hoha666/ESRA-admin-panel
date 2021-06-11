using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationLowLevelAnalyze2LowLevelAnalyzeThree
    {
        public int Id { get; set; }
        public int? LowLevelAnalyzeThreeId { get; set; }
        public int? LowLevelAnalyze2Id { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
