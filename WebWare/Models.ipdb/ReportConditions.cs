using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReportConditions
    {
        public int Id { get; set; }
        public string Field1 { get; set; }
        public int Type { get; set; }
        public string Value { get; set; }
        public string TableName2 { get; set; }
        public int? ReportDbid { get; set; }
        public int? TblReportId { get; set; }
        public string Operator { get; set; }
        public string Field2 { get; set; }

        public Reports TblReport { get; set; }
    }
}
