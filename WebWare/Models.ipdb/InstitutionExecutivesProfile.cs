using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InstitutionExecutivesProfile
    {
        public InstitutionExecutivesProfile()
        {
            ArtCulturalActivities = new HashSet<ArtCulturalActivities>();
            ExpertiseAndSkills = new HashSet<ExpertiseAndSkills>();
            WorkExperience = new HashSet<WorkExperience>();
        }

        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtLname { get; set; }
        public string TxtFatherName { get; set; }
        public string TxtNationalCode { get; set; }
        public string BornDate { get; set; }
        public string TxtIdNumber { get; set; }
        public string Ddlsexuality { get; set; }
        public string TxtPlaceOfIssue { get; set; }
        public string TxtAlias { get; set; }
        public string DdlLastDegree { get; set; }
        public string TxtFieldOfStudy { get; set; }
        public string GraduationDate { get; set; }
        public string DdlSoldiering { get; set; }
        public string TxtEducationPlace { get; set; }
        public string DdlMarriage { get; set; }
        public string TxtSpouseName { get; set; }
        public string DdlReligion { get; set; }
        public string Txtsect { get; set; }
        public string TxtNationality { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string TxtMobile { get; set; }
        public string TxaHabitationAddress { get; set; }
        public string TxtHabitationZcode { get; set; }
        public string TxtHabitationPhone { get; set; }
        public string TxtCurrentJob { get; set; }
        public string TxaCurrentJobAddress { get; set; }
        public string TxtCurrentJobPhone { get; set; }
        public string TxtPreJob { get; set; }
        public string TxaPreJobAddress { get; set; }
        public string TxtPreJobPhone { get; set; }
        public string TxaCulturalProducts { get; set; }
        public string TxaSocialActivity { get; set; }
        public string TxaComment { get; set; }
        public string CreatorInstitutionExecutivesProfile { get; set; }
        public string IpInstitutionExecutivesProfile { get; set; }
        public bool? RegistrationStatusInstitutionExecutivesProfile { get; set; }
        public string RegistrationDateInstitutionExecutivesProfile { get; set; }
        public string RegistrationTimeInstitutionExecutivesProfile { get; set; }
        public string AuditStatusInstitutionExecutivesProfile { get; set; }
        public string InstanceIdInstitutionExecutivesProfile { get; set; }
        public int? InstanceSridInstitutionExecutivesProfile { get; set; }

        public ICollection<ArtCulturalActivities> ArtCulturalActivities { get; set; }
        public ICollection<ExpertiseAndSkills> ExpertiseAndSkills { get; set; }
        public ICollection<WorkExperience> WorkExperience { get; set; }
    }
}
