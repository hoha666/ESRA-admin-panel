using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReceiveSourceFlag
    {
        public int Id { get; set; }
        public string TxtSender { get; set; }
        public string CreatorReceiveSourceFlag { get; set; }
        public string IpReceiveSourceFlag { get; set; }
        public bool? RegistrationStatusReceiveSourceFlag { get; set; }
        public string RegistrationDateReceiveSourceFlag { get; set; }
        public string RegistrationTimeReceiveSourceFlag { get; set; }
        public string AuditStatusReceiveSourceFlag { get; set; }
        public string InstanceIdReceiveSourceFlag { get; set; }
        public int? InstanceSridReceiveSourceFlag { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
