using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestPaymentCeoreview
    {
        public int Id { get; set; }
        public string DdlResultOfReview { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRequestPaymentCeoreview { get; set; }
        public string IpRequestPaymentCeoreview { get; set; }
        public bool? RegistrationStatusRequestPaymentCeoreview { get; set; }
        public string RegistrationDateRequestPaymentCeoreview { get; set; }
        public string RegistrationTimeRequestPaymentCeoreview { get; set; }
        public string AuditStatusRequestPaymentCeoreview { get; set; }
        public string InstanceIdRequestPaymentCeoreview { get; set; }
        public int? InstanceSridRequestPaymentCeoreview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
