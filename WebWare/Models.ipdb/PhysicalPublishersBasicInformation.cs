using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PhysicalPublishersBasicInformation
    {
        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtLastName { get; set; }
        public string MailEMail { get; set; }
        public string Upl { get; set; }
        public string CreatorPhysicalPublishersBasicInformation { get; set; }
        public string IpPhysicalPublishersBasicInformation { get; set; }
        public bool? RegistrationStatusPhysicalPublishersBasicInformation { get; set; }
        public string RegistrationDatePhysicalPublishersBasicInformation { get; set; }
        public string RegistrationTimePhysicalPublishersBasicInformation { get; set; }
        public string AuditStatusPhysicalPublishersBasicInformation { get; set; }
        public string InstanceIdPhysicalPublishersBasicInformation { get; set; }
        public int? InstanceSridPhysicalPublishersBasicInformation { get; set; }
        public string NumMobilePhoneNumber2 { get; set; }
        public string NumFixedPhoneNumber2 { get; set; }
        public string TxtRequestTitle { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
