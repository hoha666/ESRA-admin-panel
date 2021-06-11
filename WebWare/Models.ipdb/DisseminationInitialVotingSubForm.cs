using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DisseminationInitialVotingSubForm
    {
        public int Id { get; set; }
        public string CreatorDisseminationInitialVotingSubForm { get; set; }
        public string IpDisseminationInitialVotingSubForm { get; set; }
        public bool? RegistrationStatusDisseminationInitialVotingSubForm { get; set; }
        public string RegistrationDateDisseminationInitialVotingSubForm { get; set; }
        public string RegistrationTimeDisseminationInitialVotingSubForm { get; set; }
        public string AuditStatusDisseminationInitialVotingSubForm { get; set; }
        public string InstanceIdDisseminationInitialVotingSubForm { get; set; }
        public int? InstanceSridDisseminationInitialVotingSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public DisseminationInitialVoting ParentRecord { get; set; }
    }
}
