using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TransferPointsInitialReviewRequest
    {
        public int Id { get; set; }
        public string DdlPreliminaryReview { get; set; }
        public string AxtInternalSoftwareReviews { get; set; }
        public string AxtReviewDeputySupervisor { get; set; }
        public string AxtLegalAdvisorReview { get; set; }
        public string AxtFinancialManagerReview { get; set; }
        public string AxtRefusedRequests { get; set; }
        public string CreatorTransferPointsInitialReviewRequest { get; set; }
        public string IpTransferPointsInitialReviewRequest { get; set; }
        public bool? RegistrationStatusTransferPointsInitialReviewRequest { get; set; }
        public string RegistrationDateTransferPointsInitialReviewRequest { get; set; }
        public string RegistrationTimeTransferPointsInitialReviewRequest { get; set; }
        public string AuditStatusTransferPointsInitialReviewRequest { get; set; }
        public string InstanceIdTransferPointsInitialReviewRequest { get; set; }
        public int? InstanceSridTransferPointsInitialReviewRequest { get; set; }
    }
}
