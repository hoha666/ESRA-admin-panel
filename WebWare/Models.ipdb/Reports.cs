using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Reports
    {
        public Reports()
        {
            ReportConditions = new HashSet<ReportConditions>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Tablename { get; set; }
        public string Fields { get; set; }
        public string FieldTitle { get; set; }
        public string Condition { get; set; }
        public int ReportType { get; set; }
        public string Query { get; set; }
        public int QueryType { get; set; }
        public int SettingId { get; set; }
        public int FieldChartType { get; set; }

        public ICollection<ReportConditions> ReportConditions { get; set; }
    }
}
