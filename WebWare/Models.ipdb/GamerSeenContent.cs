using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamerSeenContent
    {
        public GamerSeenContent()
        {
            SubFormGamerSeenContent = new HashSet<SubFormGamerSeenContent>();
        }

        public int Id { get; set; }
        public string CreatorGamerSeenContent { get; set; }
        public string IpGamerSeenContent { get; set; }
        public bool? RegistrationStatusGamerSeenContent { get; set; }
        public string RegistrationDateGamerSeenContent { get; set; }
        public string RegistrationTimeGamerSeenContent { get; set; }
        public string AuditStatusGamerSeenContent { get; set; }
        public string InstanceIdGamerSeenContent { get; set; }
        public int? InstanceSridGamerSeenContent { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<SubFormGamerSeenContent> SubFormGamerSeenContent { get; set; }
    }
}
