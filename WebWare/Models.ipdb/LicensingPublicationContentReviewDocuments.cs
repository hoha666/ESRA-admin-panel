using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class LicensingPublicationContentReviewDocuments
    {
        public int Id { get; set; }
        public string DdlStatusReceivedForm { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorLicensingPublicationContentReviewDocuments { get; set; }
        public string IpLicensingPublicationContentReviewDocuments { get; set; }
        public bool? RegistrationStatusLicensingPublicationContentReviewDocuments { get; set; }
        public string RegistrationDateLicensingPublicationContentReviewDocuments { get; set; }
        public string RegistrationTimeLicensingPublicationContentReviewDocuments { get; set; }
        public string AuditStatusLicensingPublicationContentReviewDocuments { get; set; }
        public string InstanceIdLicensingPublicationContentReviewDocuments { get; set; }
        public int? InstanceSridLicensingPublicationContentReviewDocuments { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
