using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ApplicantInformation
    {
        public int Id { get; set; }
        public string TxtJobTitleRequested { get; set; }
        public string DdlMinimumQualification { get; set; }
        public string TxtFieldOfStudy { get; set; }
        public string TxtMinimumWorkExperience { get; set; }
        public string TxtSourceOfRecruiting { get; set; }
        public string TxtTypeOfEmployment { get; set; }
        public string TxtSpecialtySecondLanguage { get; set; }
        public string TxtExpertiseInIcdl { get; set; }
        public string TxtProfessionalExpertise { get; set; }
        public string TxtDescription { get; set; }
        public string CreatorApplicantInformation { get; set; }
        public string IpApplicantInformation { get; set; }
        public bool? RegistrationStatusApplicantInformation { get; set; }
        public string RegistrationDateApplicantInformation { get; set; }
        public string RegistrationTimeApplicantInformation { get; set; }
        public string AuditStatusApplicantInformation { get; set; }
        public string InstanceIdApplicantInformation { get; set; }
        public int? InstanceSridApplicantInformation { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public DeclarationHumanResourcesForm1 ParentRecord { get; set; }
    }
}
