using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RegisterPyramidTeamsApplyingForAwards
    {
        public int Id { get; set; }
        public string DdlAwardsHonors1 { get; set; }
        public string DdlAwardsHonors4 { get; set; }
        public string DdlAwardsHonors7 { get; set; }
        public string CreatorRegisterPyramidTeamsApplyingForAwards { get; set; }
        public string IpRegisterPyramidTeamsApplyingForAwards { get; set; }
        public bool? RegistrationStatusRegisterPyramidTeamsApplyingForAwards { get; set; }
        public string RegistrationDateRegisterPyramidTeamsApplyingForAwards { get; set; }
        public string RegistrationTimeRegisterPyramidTeamsApplyingForAwards { get; set; }
        public string AuditStatusRegisterPyramidTeamsApplyingForAwards { get; set; }
        public string InstanceIdRegisterPyramidTeamsApplyingForAwards { get; set; }
        public int? InstanceSridRegisterPyramidTeamsApplyingForAwards { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
