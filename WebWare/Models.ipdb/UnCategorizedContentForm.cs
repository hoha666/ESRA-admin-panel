using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UnCategorizedContentForm
    {
        public int Id { get; set; }
        public string DdlSath { get; set; }
        public string TxaTozihat { get; set; }
        public string TxtFileName { get; set; }
        public string TxtTime { get; set; }
        public string DdlSource { get; set; }
        public string UplFilm { get; set; }
        public string CreatorUnCategorizedContentForm { get; set; }
        public string IpUnCategorizedContentForm { get; set; }
        public bool? RegistrationStatusUnCategorizedContentForm { get; set; }
        public string RegistrationDateUnCategorizedContentForm { get; set; }
        public string RegistrationTimeUnCategorizedContentForm { get; set; }
        public string AuditStatusUnCategorizedContentForm { get; set; }
        public string InstanceIdUnCategorizedContentForm { get; set; }
        public int? InstanceSridUnCategorizedContentForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public AnalyzeReportForm ParentRecord { get; set; }
    }
}
