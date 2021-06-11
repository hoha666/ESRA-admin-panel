using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestPaymentFinancialDeputyReview
    {
        public int Id { get; set; }
        public string DdlResultOfReview { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRequestPaymentFinancialDeputyReview { get; set; }
        public string IpRequestPaymentFinancialDeputyReview { get; set; }
        public bool? RegistrationStatusRequestPaymentFinancialDeputyReview { get; set; }
        public string RegistrationDateRequestPaymentFinancialDeputyReview { get; set; }
        public string RegistrationTimeRequestPaymentFinancialDeputyReview { get; set; }
        public string AuditStatusRequestPaymentFinancialDeputyReview { get; set; }
        public string InstanceIdRequestPaymentFinancialDeputyReview { get; set; }
        public int? InstanceSridRequestPaymentFinancialDeputyReview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
