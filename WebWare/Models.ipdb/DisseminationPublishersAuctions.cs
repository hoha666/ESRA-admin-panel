using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DisseminationPublishersAuctions
    {
        public int Id { get; set; }
        public string DdlPublishersParticipatingAuctions { get; set; }
        public string CreatorDisseminationPublishersAuctions { get; set; }
        public string IpDisseminationPublishersAuctions { get; set; }
        public bool? RegistrationStatusDisseminationPublishersAuctions { get; set; }
        public string RegistrationDateDisseminationPublishersAuctions { get; set; }
        public string RegistrationTimeDisseminationPublishersAuctions { get; set; }
        public string AuditStatusDisseminationPublishersAuctions { get; set; }
        public string InstanceIdDisseminationPublishersAuctions { get; set; }
        public int? InstanceSridDisseminationPublishersAuctions { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
