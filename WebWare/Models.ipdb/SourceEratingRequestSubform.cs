using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SourceEratingRequestSubform
    {
        public int Id { get; set; }
        public string TxtMediaSourceType { get; set; }
        public string TxtNumber { get; set; }
        public string DdlSourceType { get; set; }
        public string DdlPlatform { get; set; }
        public string TxtSite { get; set; }
        public string CreatorSourceEratingRequestSubform { get; set; }
        public string IpSourceEratingRequestSubform { get; set; }
        public bool? RegistrationStatusSourceEratingRequestSubform { get; set; }
        public string RegistrationDateSourceEratingRequestSubform { get; set; }
        public string RegistrationTimeSourceEratingRequestSubform { get; set; }
        public string AuditStatusSourceEratingRequestSubform { get; set; }
        public string InstanceIdSourceEratingRequestSubform { get; set; }
        public int? InstanceSridSourceEratingRequestSubform { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public SeratingRequest ParentRecord { get; set; }
    }
}
