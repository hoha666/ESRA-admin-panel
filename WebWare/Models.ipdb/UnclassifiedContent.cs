using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UnclassifiedContent
    {
        public int Id { get; set; }
        public string TxaComment { get; set; }
        public string TxtFileName { get; set; }
        public string Time { get; set; }
        public string TxtContentSource { get; set; }
        public string FileUpload { get; set; }
        public string CreatorUnclassifiedContent { get; set; }
        public string IpUnclassifiedContent { get; set; }
        public bool? RegistrationStatusUnclassifiedContent { get; set; }
        public string RegistrationDateUnclassifiedContent { get; set; }
        public string RegistrationTimeUnclassifiedContent { get; set; }
        public string AuditStatusUnclassifiedContent { get; set; }
        public string InstanceIdUnclassifiedContent { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridUnclassifiedContent { get; set; }
        public string Iuygveirtyreiutyiervbteritbyrrvtyutyuntyuntyuyt { get; set; }

        public AnalyzerReport ParentRecord { get; set; }
    }
}
