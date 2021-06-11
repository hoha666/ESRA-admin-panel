using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ValetChecking
    {
        public ValetChecking()
        {
            RelationValetUploadsValetChecking = new HashSet<RelationValetUploadsValetChecking>();
        }

        public int Id { get; set; }
        public string CreatorValetChecking { get; set; }
        public string IpValetChecking { get; set; }
        public bool? RegistrationStatusValetChecking { get; set; }
        public string RegistrationDateValetChecking { get; set; }
        public string RegistrationTimeValetChecking { get; set; }
        public string AuditStatusValetChecking { get; set; }
        public string InstanceIdValetChecking { get; set; }
        public int? InstanceSridValetChecking { get; set; }

        public ICollection<RelationValetUploadsValetChecking> RelationValetUploadsValetChecking { get; set; }
    }
}
