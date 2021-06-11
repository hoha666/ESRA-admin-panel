using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Indices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndexSymbol { get; set; }
        public string Issue { get; set; }
        public string Subject { get; set; }
        public string QueryTable { get; set; }
        public string ParameterSymbol { get; set; }
        public string ParameterTitle { get; set; }
        public string TypeDb { get; set; }
        public string File { get; set; }
        public string Dimension { get; set; }
        public string ChartText { get; set; }
        public string Measures { get; set; }
        public string ChartType { get; set; }
        public string Description { get; set; }
        public int? BscId { get; set; }
        public int? ScheduleTargetId { get; set; }

        public Bscs Bsc { get; set; }
        public ScheduleTargets ScheduleTarget { get; set; }
    }
}
