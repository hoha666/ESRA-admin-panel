using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SelectMyBosses
    {
        public SelectMyBosses()
        {
            RelationGameMarketListSelectMyBosses = new HashSet<RelationGameMarketListSelectMyBosses>();
        }

        public int Id { get; set; }
        public string CreatorSelectMyBosses { get; set; }
        public string IpSelectMyBosses { get; set; }
        public bool? RegistrationStatusSelectMyBosses { get; set; }
        public string RegistrationDateSelectMyBosses { get; set; }
        public string RegistrationTimeSelectMyBosses { get; set; }
        public string AuditStatusSelectMyBosses { get; set; }
        public string InstanceIdSelectMyBosses { get; set; }
        public int? InstanceSridSelectMyBosses { get; set; }

        public ICollection<RelationGameMarketListSelectMyBosses> RelationGameMarketListSelectMyBosses { get; set; }
    }
}
