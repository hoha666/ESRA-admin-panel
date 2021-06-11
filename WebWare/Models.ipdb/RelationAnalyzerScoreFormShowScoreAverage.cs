using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationAnalyzerScoreFormShowScoreAverage
    {
        public int Id { get; set; }
        public int? ShowScoreAverageId { get; set; }
        public int? AnalyzerScoreFormId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
