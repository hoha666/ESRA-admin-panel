using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramReviewFinancialRequest
    {
        public int Id { get; set; }
        public string AxtActionOrder { get; set; }
        public string AxtReasonRefusal { get; set; }
        public string CreatorGreenHologramReviewFinancialRequest { get; set; }
        public string IpGreenHologramReviewFinancialRequest { get; set; }
        public bool? RegistrationStatusGreenHologramReviewFinancialRequest { get; set; }
        public string RegistrationDateGreenHologramReviewFinancialRequest { get; set; }
        public string RegistrationTimeGreenHologramReviewFinancialRequest { get; set; }
        public string AuditStatusGreenHologramReviewFinancialRequest { get; set; }
        public string InstanceIdGreenHologramReviewFinancialRequest { get; set; }
        public int? InstanceSridGreenHologramReviewFinancialRequest { get; set; }
        public string DdlResultReview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
