using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class LegalPersonRegistrationCompletePreRegistrationForm
    {
        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtLastName { get; set; }
        public string NumNationalCode { get; set; }
        public string TxtPassword { get; set; }
        public string MailEmail { get; set; }
        public string CreatorLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public string IpLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public bool? RegistrationStatusLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public string RegistrationDateLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public string RegistrationTimeLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public string AuditStatusLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public string InstanceIdLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public int? InstanceSridLegalPersonRegistrationCompletePreRegistrationForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string TxtPassword2 { get; set; }
    }
}
