using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CouncilReport
    {
        public int Id { get; set; }
        public string Ddl2AgeRating { get; set; }
        public string DdlOpinion { get; set; }
        public string Ddl2ConditionalRating { get; set; }
        public string TxaComment { get; set; }
        public string Date { get; set; }
        public string DdlType { get; set; }
        public string CreatorCouncilReport { get; set; }
        public string IpCouncilReport { get; set; }
        public bool? RegistrationStatusCouncilReport { get; set; }
        public string RegistrationDateCouncilReport { get; set; }
        public string RegistrationTimeCouncilReport { get; set; }
        public string AuditStatusCouncilReport { get; set; }
        public string InstanceIdCouncilReport { get; set; }
        public string Upload { get; set; }
        public int? InstanceSridCouncilReport { get; set; }
        public DateTime? DateGregorian { get; set; }
    }
}
