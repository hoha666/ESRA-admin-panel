using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InquiryOfLicencingUnit
    {
        public int Id { get; set; }
        public string TxtActivityTitle { get; set; }
        public string DdlResult { get; set; }
        public string TxaComment { get; set; }
        public string CreatorInquiryOfLicencingUnit { get; set; }
        public string IpInquiryOfLicencingUnit { get; set; }
        public bool? RegistrationStatusInquiryOfLicencingUnit { get; set; }
        public string RegistrationDateInquiryOfLicencingUnit { get; set; }
        public string RegistrationTimeInquiryOfLicencingUnit { get; set; }
        public string AuditStatusInquiryOfLicencingUnit { get; set; }
        public string InstanceIdInquiryOfLicencingUnit { get; set; }
        public int? InstanceSridInquiryOfLicencingUnit { get; set; }
    }
}
