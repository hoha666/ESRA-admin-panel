using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ExpertiseAndSkills
    {
        public int Id { get; set; }
        public string TxtExpertName { get; set; }
        public string TxtLearningPlace { get; set; }
        public string DdlLevel { get; set; }
        public string CreatorExpertiseAndSkills { get; set; }
        public string IpExpertiseAndSkills { get; set; }
        public bool? RegistrationStatusExpertiseAndSkills { get; set; }
        public string RegistrationDateExpertiseAndSkills { get; set; }
        public string RegistrationTimeExpertiseAndSkills { get; set; }
        public string AuditStatusExpertiseAndSkills { get; set; }
        public string InstanceIdExpertiseAndSkills { get; set; }
        public int? InstanceSridExpertiseAndSkills { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public InstitutionExecutivesProfile ParentRecord { get; set; }
    }
}
