using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InsertAndEditReviewDeputyNezarat
    {
        public int Id { get; set; }
        public string DdlResultOfReview { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorInsertAndEditReviewDeputyNezarat { get; set; }
        public string IpInsertAndEditReviewDeputyNezarat { get; set; }
        public bool? RegistrationStatusInsertAndEditReviewDeputyNezarat { get; set; }
        public string RegistrationDateInsertAndEditReviewDeputyNezarat { get; set; }
        public string RegistrationTimeInsertAndEditReviewDeputyNezarat { get; set; }
        public string AuditStatusInsertAndEditReviewDeputyNezarat { get; set; }
        public string InstanceIdInsertAndEditReviewDeputyNezarat { get; set; }
        public int? InstanceSridInsertAndEditReviewDeputyNezarat { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
