using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UserIdeditorFinalInformation
    {
        public int Id { get; set; }
        public string DdlApplicantType { get; set; }
        public string TxtNameCompany { get; set; }
        public string NumRegistrationNumber { get; set; }
        public string NumEconomicCode { get; set; }
        public string PdateDateRegistration { get; set; }
        public DateTime? PdateDateRegistrationGregorian { get; set; }
        public string DdlKind { get; set; }
        public string NumPostalCode { get; set; }
        public string TxtNameCeo { get; set; }
        public string TxtSurnameCeo { get; set; }
        public string AxtDescription { get; set; }
        public string UplDocumentation { get; set; }
        public string CreatorUserIdeditorFinalInformation { get; set; }
        public string IpUserIdeditorFinalInformation { get; set; }
        public bool? RegistrationStatusUserIdeditorFinalInformation { get; set; }
        public string RegistrationDateUserIdeditorFinalInformation { get; set; }
        public string RegistrationTimeUserIdeditorFinalInformation { get; set; }
        public string AuditStatusUserIdeditorFinalInformation { get; set; }
        public string InstanceIdUserIdeditorFinalInformation { get; set; }
        public int? InstanceSridUserIdeditorFinalInformation { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string NumNationalCodeCeo { get; set; }
    }
}
