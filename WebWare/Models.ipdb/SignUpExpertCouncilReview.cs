using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SignUpExpertCouncilReview
    {
        public int Id { get; set; }
        public string CkeDisapproveRequest { get; set; }
        public string CreatorSignUpExpertCouncilReview { get; set; }
        public string IpSignUpExpertCouncilReview { get; set; }
        public bool? RegistrationStatusSignUpExpertCouncilReview { get; set; }
        public string RegistrationDateSignUpExpertCouncilReview { get; set; }
        public string RegistrationTimeSignUpExpertCouncilReview { get; set; }
        public string AuditStatusSignUpExpertCouncilReview { get; set; }
        public string InstanceIdSignUpExpertCouncilReview { get; set; }
        public int? InstanceSridSignUpExpertCouncilReview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
