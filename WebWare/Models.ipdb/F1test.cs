using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class F1test
    {
        public int Id { get; set; }
        public string Txtone { get; set; }
        public string CreatorF1test { get; set; }
        public string IpF1test { get; set; }
        public bool? RegistrationStatusF1test { get; set; }
        public string RegistrationDateF1test { get; set; }
        public string RegistrationTimeF1test { get; set; }
        public string AuditStatusF1test { get; set; }
        public string InstanceIdF1test { get; set; }
        public int? InstanceSridF1test { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
