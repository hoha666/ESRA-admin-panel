using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SupportReplyRequestForm
    {
        public int Id { get; set; }
        public string TxtText { get; set; }
        public string FileUpl { get; set; }
        public string CreatorSupportReplyRequestForm { get; set; }
        public string IpSupportReplyRequestForm { get; set; }
        public bool? RegistrationStatusSupportReplyRequestForm { get; set; }
        public string RegistrationDateSupportReplyRequestForm { get; set; }
        public string RegistrationTimeSupportReplyRequestForm { get; set; }
        public string AuditStatusSupportReplyRequestForm { get; set; }
        public string InstanceIdSupportReplyRequestForm { get; set; }
        public int? InstanceSridSupportReplyRequestForm { get; set; }
    }
}
