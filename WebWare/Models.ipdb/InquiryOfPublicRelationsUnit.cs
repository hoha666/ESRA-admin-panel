using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InquiryOfPublicRelationsUnit
    {
        public int Id { get; set; }
        public string TxtActivityTitle { get; set; }
        public string DdlResult { get; set; }
        public string TxaComment { get; set; }
        public string CreatorInquiryOfPublicRelationsUnit { get; set; }
        public string IpInquiryOfPublicRelationsUnit { get; set; }
        public bool? RegistrationStatusInquiryOfPublicRelationsUnit { get; set; }
        public string RegistrationDateInquiryOfPublicRelationsUnit { get; set; }
        public string RegistrationTimeInquiryOfPublicRelationsUnit { get; set; }
        public string AuditStatusInquiryOfPublicRelationsUnit { get; set; }
        public string InstanceIdInquiryOfPublicRelationsUnit { get; set; }
        public int? InstanceSridInquiryOfPublicRelationsUnit { get; set; }
    }
}
