using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SignUpExpertCompletedRegistration
    {
        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtLastName { get; set; }
        public string NumNationalCode { get; set; }
        public string DdlIndividual1 { get; set; }
        public string DdlIndividual2 { get; set; }
        public string TxtIndividual3 { get; set; }
        public string PdateIndividual4 { get; set; }
        public DateTime? PdateIndividual4Gregorian { get; set; }
        public string TxtIndividual5 { get; set; }
        public string DdlContact1 { get; set; }
        public string DdlContact2 { get; set; }
        public string TxtContact3 { get; set; }
        public string TxtContact4 { get; set; }
        public string TxtContact5 { get; set; }
        public string TxtContact6 { get; set; }
        public string MailContact7 { get; set; }
        public string CkeContact8 { get; set; }
        public string UplRecords1 { get; set; }
        public string UplRecords2 { get; set; }
        public string UplRecords3 { get; set; }
        public string UplRecords4 { get; set; }
        public string CreatorSignUpExpertCompletedRegistration { get; set; }
        public string IpSignUpExpertCompletedRegistration { get; set; }
        public bool? RegistrationStatusSignUpExpertCompletedRegistration { get; set; }
        public string RegistrationDateSignUpExpertCompletedRegistration { get; set; }
        public string RegistrationTimeSignUpExpertCompletedRegistration { get; set; }
        public string AuditStatusSignUpExpertCompletedRegistration { get; set; }
        public string InstanceIdSignUpExpertCompletedRegistration { get; set; }
        public int? InstanceSridSignUpExpertCompletedRegistration { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
