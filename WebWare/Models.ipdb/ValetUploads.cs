using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ValetUploads
    {
        public ValetUploads()
        {
            RelationValetUploadsValetChecking = new HashSet<RelationValetUploadsValetChecking>();
        }

        public int Id { get; set; }
        public string CreatorValetUploads { get; set; }
        public string IpValetUploads { get; set; }
        public bool? RegistrationStatusValetUploads { get; set; }
        public string RegistrationDateValetUploads { get; set; }
        public string RegistrationTimeValetUploads { get; set; }
        public string AuditStatusValetUploads { get; set; }
        public string InstanceIdValetUploads { get; set; }
        public int? InstanceSridValetUploads { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string ValetUploads1 { get; set; }

        public IssuingPublishCertificate ParentRecord { get; set; }
        public ICollection<RelationValetUploadsValetChecking> RelationValetUploadsValetChecking { get; set; }
    }
}
