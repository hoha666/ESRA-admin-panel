using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RatingAccountFinancialManagerReview
    {
        public int Id { get; set; }
        public string DdlResultApplicationReview { get; set; }
        public string AxtNeedCorrection { get; set; }
        public int? NumScoreApproved { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRatingAccountFinancialManagerReview { get; set; }
        public string IpRatingAccountFinancialManagerReview { get; set; }
        public bool? RegistrationStatusRatingAccountFinancialManagerReview { get; set; }
        public string RegistrationDateRatingAccountFinancialManagerReview { get; set; }
        public string RegistrationTimeRatingAccountFinancialManagerReview { get; set; }
        public string AuditStatusRatingAccountFinancialManagerReview { get; set; }
        public string InstanceIdRatingAccountFinancialManagerReview { get; set; }
        public int? InstanceSridRatingAccountFinancialManagerReview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
