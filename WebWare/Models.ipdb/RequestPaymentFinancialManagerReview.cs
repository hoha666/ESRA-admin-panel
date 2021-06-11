using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestPaymentFinancialManagerReview
    {
        public int Id { get; set; }
        public string DdlResultOfReview { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRequestPaymentFinancialManagerReview { get; set; }
        public string IpRequestPaymentFinancialManagerReview { get; set; }
        public bool? RegistrationStatusRequestPaymentFinancialManagerReview { get; set; }
        public string RegistrationDateRequestPaymentFinancialManagerReview { get; set; }
        public string RegistrationTimeRequestPaymentFinancialManagerReview { get; set; }
        public string AuditStatusRequestPaymentFinancialManagerReview { get; set; }
        public string InstanceIdRequestPaymentFinancialManagerReview { get; set; }
        public int? InstanceSridRequestPaymentFinancialManagerReview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
