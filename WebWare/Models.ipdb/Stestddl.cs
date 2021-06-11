using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Stestddl
    {
        public int Id { get; set; }
        public string Ddla { get; set; }
        public string Ddlb { get; set; }
        public string Txtc { get; set; }
        public string Txtd { get; set; }
        public string CreatorStestddl { get; set; }
        public string IpStestddl { get; set; }
        public bool? RegistrationStatusStestddl { get; set; }
        public string RegistrationDateStestddl { get; set; }
        public string RegistrationTimeStestddl { get; set; }
        public string AuditStatusStestddl { get; set; }
        public string InstanceIdStestddl { get; set; }
        public int? InstanceSridStestddl { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string Txte { get; set; }
    }
}
