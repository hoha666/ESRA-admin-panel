using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RealDocUpload
    {
        public int Id { get; set; }
        public string Bcpic { get; set; }
        public string Ncpic { get; set; }
        public string Ecpic { get; set; }
        public string ResumePic { get; set; }
        public string CreatorRealDocUpload { get; set; }
        public string IpRealDocUpload { get; set; }
        public bool? RegistrationStatusRealDocUpload { get; set; }
        public string RegistrationDateRealDocUpload { get; set; }
        public string RegistrationTimeRealDocUpload { get; set; }
        public string AuditStatusRealDocUpload { get; set; }
        public string InstanceIdRealDocUpload { get; set; }
        public int? InstanceSridRealDocUpload { get; set; }
        public string TxaComment { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
