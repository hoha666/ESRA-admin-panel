using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Checkemail
    {
        public int Id { get; set; }
        public string MaileMail { get; set; }
        public string CreatorCheckemail { get; set; }
        public string IpCheckemail { get; set; }
        public bool? RegistrationStatusCheckemail { get; set; }
        public string RegistrationDateCheckemail { get; set; }
        public string RegistrationTimeCheckemail { get; set; }
        public string AuditStatusCheckemail { get; set; }
        public string InstanceIdCheckemail { get; set; }
        public int? InstanceSridCheckemail { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
