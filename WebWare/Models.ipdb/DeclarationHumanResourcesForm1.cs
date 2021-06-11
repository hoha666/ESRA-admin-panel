using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DeclarationHumanResourcesForm1
    {
        public DeclarationHumanResourcesForm1()
        {
            ApplicantInformation = new HashSet<ApplicantInformation>();
        }

        public int Id { get; set; }
        public string DdlApplicantUnit { get; set; }
        public int? NumRequiredForce { get; set; }
        public string DdlGender { get; set; }
        public string DdlTheAgeRange { get; set; }
        public string CreatorDeclarationHumanResourcesForm1 { get; set; }
        public string IpDeclarationHumanResourcesForm1 { get; set; }
        public bool? RegistrationStatusDeclarationHumanResourcesForm1 { get; set; }
        public string RegistrationDateDeclarationHumanResourcesForm1 { get; set; }
        public string RegistrationTimeDeclarationHumanResourcesForm1 { get; set; }
        public string AuditStatusDeclarationHumanResourcesForm1 { get; set; }
        public string InstanceIdDeclarationHumanResourcesForm1 { get; set; }
        public int? InstanceSridDeclarationHumanResourcesForm1 { get; set; }

        public ICollection<ApplicantInformation> ApplicantInformation { get; set; }
    }
}
