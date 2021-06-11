using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DisseminationInitialVoting
    {
        public DisseminationInitialVoting()
        {
            DisseminationInitialVotingSubForm = new HashSet<DisseminationInitialVotingSubForm>();
        }

        public int Id { get; set; }
        public string CreatorDisseminationInitialVoting { get; set; }
        public string IpDisseminationInitialVoting { get; set; }
        public bool? RegistrationStatusDisseminationInitialVoting { get; set; }
        public string RegistrationDateDisseminationInitialVoting { get; set; }
        public string RegistrationTimeDisseminationInitialVoting { get; set; }
        public string AuditStatusDisseminationInitialVoting { get; set; }
        public string InstanceIdDisseminationInitialVoting { get; set; }
        public int? InstanceSridDisseminationInitialVoting { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<DisseminationInitialVotingSubForm> DisseminationInitialVotingSubForm { get; set; }
    }
}
