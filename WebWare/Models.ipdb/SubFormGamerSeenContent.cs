using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubFormGamerSeenContent
    {
        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string DdlType { get; set; }
        public string TxaDesc { get; set; }
        public string UplSubjectMovie { get; set; }
        public string CreatorSubFormGamerSeenContent { get; set; }
        public string IpSubFormGamerSeenContent { get; set; }
        public bool? RegistrationStatusSubFormGamerSeenContent { get; set; }
        public string RegistrationDateSubFormGamerSeenContent { get; set; }
        public string RegistrationTimeSubFormGamerSeenContent { get; set; }
        public string AuditStatusSubFormGamerSeenContent { get; set; }
        public string InstanceIdSubFormGamerSeenContent { get; set; }
        public int? InstanceSridSubFormGamerSeenContent { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public GamerSeenContent ParentRecord { get; set; }
    }
}
