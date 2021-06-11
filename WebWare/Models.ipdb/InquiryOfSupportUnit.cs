using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InquiryOfSupportUnit
    {
        public int Id { get; set; }
        public string TxtActivityTitle { get; set; }
        public string DdlResult { get; set; }
        public string TxaComment { get; set; }
        public string CreatorInquiryOfSupportUnit { get; set; }
        public string IpInquiryOfSupportUnit { get; set; }
        public bool? RegistrationStatusInquiryOfSupportUnit { get; set; }
        public string RegistrationDateInquiryOfSupportUnit { get; set; }
        public string RegistrationTimeInquiryOfSupportUnit { get; set; }
        public string AuditStatusInquiryOfSupportUnit { get; set; }
        public string InstanceIdInquiryOfSupportUnit { get; set; }
        public int? InstanceSridInquiryOfSupportUnit { get; set; }
    }
}
