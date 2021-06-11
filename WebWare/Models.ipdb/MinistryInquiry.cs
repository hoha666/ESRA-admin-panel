using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MinistryInquiry
    {
        public int Id { get; set; }
        public string InquiryLetter { get; set; }
        public string InquirySletter { get; set; }
        public string InquiryLetterDate { get; set; }
        public string CreatorMinistryInquiry { get; set; }
        public string IpMinistryInquiry { get; set; }
        public bool? RegistrationStatusMinistryInquiry { get; set; }
        public string RegistrationDateMinistryInquiry { get; set; }
        public string RegistrationTimeMinistryInquiry { get; set; }
        public string AuditStatusMinistryInquiry { get; set; }
        public string InstanceIdMinistryInquiry { get; set; }
        public int? InstanceSridMinistryInquiry { get; set; }
    }
}
