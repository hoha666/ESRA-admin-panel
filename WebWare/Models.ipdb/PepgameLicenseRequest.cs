using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PepgameLicenseRequest
    {
        public PepgameLicenseRequest()
        {
            FoundingBoardInformation = new HashSet<FoundingBoardInformation>();
        }

        public int Id { get; set; }
        public string Flname { get; set; }
        public string MgntTel { get; set; }
        public string MgntPhone { get; set; }
        public string MgntAddress { get; set; }
        public string Email { get; set; }
        public string MgntNipic { get; set; }
        public string MgntBcpic { get; set; }
        public string VeteranStatus { get; set; }
        public string VeteranPic { get; set; }
        public string MgntResume { get; set; }
        public string MgntEduPic { get; set; }
        public string CompanyName { get; set; }
        public string CompanyId { get; set; }
        public string CompanySubmitDate { get; set; }
        public string ActivityTitle { get; set; }
        public string CompanyTel { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanySite { get; set; }
        public string OfficialNewspaper { get; set; }
        public string CompayStatute { get; set; }
        public string MinistryLicense { get; set; }
        public string CompanyResume { get; set; }
        public string CreatorPepgameLicenseRequest { get; set; }
        public string IpPepgameLicenseRequest { get; set; }
        public bool? RegistrationStatusPepgameLicenseRequest { get; set; }
        public string RegistrationDatePepgameLicenseRequest { get; set; }
        public string RegistrationTimePepgameLicenseRequest { get; set; }
        public string AuditStatusPepgameLicenseRequest { get; set; }
        public string InstanceIdPepgameLicenseRequest { get; set; }
        public int? InstanceSridPepgameLicenseRequest { get; set; }
        public string CompanyAddress { get; set; }
        public string RequestType { get; set; }
        public DateTime? CompanySubmitDateGregorian { get; set; }

        public ICollection<FoundingBoardInformation> FoundingBoardInformation { get; set; }
    }
}
