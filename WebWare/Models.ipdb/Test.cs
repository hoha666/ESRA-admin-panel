using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Test
    {
        public int Id { get; set; }
        public string CreatorTest { get; set; }
        public string IpTest { get; set; }
        public bool? RegistrationStatusTest { get; set; }
        public string RegistrationDateTest { get; set; }
        public string RegistrationTimeTest { get; set; }
        public string AuditStatusTest { get; set; }
        public string InstanceIdTest { get; set; }
        public int? InstanceSridTest { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
