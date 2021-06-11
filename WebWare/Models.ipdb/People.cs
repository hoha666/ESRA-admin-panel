using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class People
    {
        public People()
        {
            DependantPersons = new HashSet<DependantPersons>();
            EducationalBackgrounds = new HashSet<EducationalBackgrounds>();
            JobBackgrounds = new HashSet<JobBackgrounds>();
            PersonalInformations = new HashSet<PersonalInformations>();
            PostPeoples = new HashSet<PostPeoples>();
            RelationPeopleAgreementRequest = new HashSet<RelationPeopleAgreementRequest>();
            RelationPeopleContractFirstRequest = new HashSet<RelationPeopleContractFirstRequest>();
            RelationPeopleContractUpload = new HashSet<RelationPeopleContractUpload>();
            RelationPeopleSuportReplyForm = new HashSet<RelationPeopleSuportReplyForm>();
            RelationPeopleSupportMgntCheck = new HashSet<RelationPeopleSupportMgntCheck>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public bool IsPersonnel { get; set; }
        public string FileId { get; set; }
        public string IdentityNumber { get; set; }
        public string NationalCode { get; set; }
        public bool Sex { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string WorkPhone { get; set; }
        public string Mobilephone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
        public int? PostId { get; set; }
        public string Picture { get; set; }

        public ICollection<DependantPersons> DependantPersons { get; set; }
        public ICollection<EducationalBackgrounds> EducationalBackgrounds { get; set; }
        public ICollection<JobBackgrounds> JobBackgrounds { get; set; }
        public ICollection<PersonalInformations> PersonalInformations { get; set; }
        public ICollection<PostPeoples> PostPeoples { get; set; }
        public ICollection<RelationPeopleAgreementRequest> RelationPeopleAgreementRequest { get; set; }
        public ICollection<RelationPeopleContractFirstRequest> RelationPeopleContractFirstRequest { get; set; }
        public ICollection<RelationPeopleContractUpload> RelationPeopleContractUpload { get; set; }
        public ICollection<RelationPeopleSuportReplyForm> RelationPeopleSuportReplyForm { get; set; }
        public ICollection<RelationPeopleSupportMgntCheck> RelationPeopleSupportMgntCheck { get; set; }
    }
}
