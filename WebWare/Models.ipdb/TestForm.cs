using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TestForm
    {
        public int Id { get; set; }
        public string CreatorTestForm { get; set; }
        public string IpTestForm { get; set; }
        public bool? RegistrationStatusTestForm { get; set; }
        public string RegistrationDateTestForm { get; set; }
        public string RegistrationTimeTestForm { get; set; }
        public string AuditStatusTestForm { get; set; }
        public string InstanceIdTestForm { get; set; }
        public int? InstanceSridTestForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string Txta { get; set; }
    }
}
