using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UserIdeditorPrimaryInformation
    {
        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtLastName { get; set; }
        public string NumFixedPhoneNumber { get; set; }
        public string NumMobilePhoneNumber { get; set; }
        public string MailEmail { get; set; }
        public string UplRequestDocumentationImage { get; set; }
        public string CreatorUserIdeditorPrimaryInformation { get; set; }
        public string IpUserIdeditorPrimaryInformation { get; set; }
        public bool? RegistrationStatusUserIdeditorPrimaryInformation { get; set; }
        public string RegistrationDateUserIdeditorPrimaryInformation { get; set; }
        public string RegistrationTimeUserIdeditorPrimaryInformation { get; set; }
        public string AuditStatusUserIdeditorPrimaryInformation { get; set; }
        public string InstanceIdUserIdeditorPrimaryInformation { get; set; }
        public int? InstanceSridUserIdeditorPrimaryInformation { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
