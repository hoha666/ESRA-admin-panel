using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SupportMgntCheck
    {
        public SupportMgntCheck()
        {
            RelationPeopleSupportMgntCheck = new HashSet<RelationPeopleSupportMgntCheck>();
        }

        public int Id { get; set; }
        public string CreatorSupportMgntCheck { get; set; }
        public string IpSupportMgntCheck { get; set; }
        public bool? RegistrationStatusSupportMgntCheck { get; set; }
        public string RegistrationDateSupportMgntCheck { get; set; }
        public string RegistrationTimeSupportMgntCheck { get; set; }
        public string AuditStatusSupportMgntCheck { get; set; }
        public string InstanceIdSupportMgntCheck { get; set; }
        public int? InstanceSridSupportMgntCheck { get; set; }
        public string Comment { get; set; }

        public ICollection<RelationPeopleSupportMgntCheck> RelationPeopleSupportMgntCheck { get; set; }
    }
}
