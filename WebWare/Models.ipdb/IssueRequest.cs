using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class IssueRequest
    {
        public int Id { get; set; }
        public string TxtIssue { get; set; }
        public string CreatorIssueRequest { get; set; }
        public string IpIssueRequest { get; set; }
        public bool? RegistrationStatusIssueRequest { get; set; }
        public string RegistrationDateIssueRequest { get; set; }
        public string RegistrationTimeIssueRequest { get; set; }
        public string AuditStatusIssueRequest { get; set; }
        public string InstanceIdIssueRequest { get; set; }
        public int? InstanceSridIssueRequest { get; set; }
    }
}
