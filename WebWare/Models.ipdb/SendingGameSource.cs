using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SendingGameSource
    {
        public int Id { get; set; }
        public string SendingType { get; set; }
        public string FileUpload { get; set; }
        public string CreatorSendingGameSource { get; set; }
        public string IpSendingGameSource { get; set; }
        public bool? RegistrationStatusSendingGameSource { get; set; }
        public string RegistrationDateSendingGameSource { get; set; }
        public string RegistrationTimeSendingGameSource { get; set; }
        public string AuditStatusSendingGameSource { get; set; }
        public string InstanceIdSendingGameSource { get; set; }
        public int? InstanceSridSendingGameSource { get; set; }
    }
}
