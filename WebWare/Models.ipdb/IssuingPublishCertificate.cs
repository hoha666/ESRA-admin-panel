using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class IssuingPublishCertificate
    {
        public IssuingPublishCertificate()
        {
            ValetUploads = new HashSet<ValetUploads>();
        }

        public int Id { get; set; }
        public string PrePccode { get; set; }
        public string CreatorIssuingPublishCertificate { get; set; }
        public string IpIssuingPublishCertificate { get; set; }
        public bool? RegistrationStatusIssuingPublishCertificate { get; set; }
        public string RegistrationDateIssuingPublishCertificate { get; set; }
        public string RegistrationTimeIssuingPublishCertificate { get; set; }
        public string AuditStatusIssuingPublishCertificate { get; set; }
        public string InstanceIdIssuingPublishCertificate { get; set; }
        public int? InstanceSridIssuingPublishCertificate { get; set; }

        public ICollection<ValetUploads> ValetUploads { get; set; }
    }
}
