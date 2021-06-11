using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Cbtest
    {
        public int Id { get; set; }
        public string Cba { get; set; }
        public string Txtb { get; set; }
        public string CreatorCbtest { get; set; }
        public string IpCbtest { get; set; }
        public bool? RegistrationStatusCbtest { get; set; }
        public string RegistrationDateCbtest { get; set; }
        public string RegistrationTimeCbtest { get; set; }
        public string AuditStatusCbtest { get; set; }
        public string InstanceIdCbtest { get; set; }
        public int? InstanceSridCbtest { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
