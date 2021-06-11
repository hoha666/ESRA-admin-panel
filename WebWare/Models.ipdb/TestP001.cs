using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TestP001
    {
        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string TxtTitle2 { get; set; }
        public string DrpChoose { get; set; }
        public string CreatorTestP001 { get; set; }
        public string IpTestP001 { get; set; }
        public bool? RegistrationStatusTestP001 { get; set; }
        public string RegistrationDateTestP001 { get; set; }
        public string RegistrationTimeTestP001 { get; set; }
        public string AuditStatusTestP001 { get; set; }
        public string InstanceIdTestP001 { get; set; }
        public int? InstanceSridTestP001 { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
