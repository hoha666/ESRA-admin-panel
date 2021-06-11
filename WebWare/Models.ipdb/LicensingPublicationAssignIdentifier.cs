using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class LicensingPublicationAssignIdentifier
    {
        public int Id { get; set; }
        public string TxtApplicantId { get; set; }
        public string TxtApplicantPass { get; set; }
        public string CreatorLicensingPublicationAssignIdentifier { get; set; }
        public string IpLicensingPublicationAssignIdentifier { get; set; }
        public bool? RegistrationStatusLicensingPublicationAssignIdentifier { get; set; }
        public string RegistrationDateLicensingPublicationAssignIdentifier { get; set; }
        public string RegistrationTimeLicensingPublicationAssignIdentifier { get; set; }
        public string AuditStatusLicensingPublicationAssignIdentifier { get; set; }
        public string InstanceIdLicensingPublicationAssignIdentifier { get; set; }
        public int? InstanceSridLicensingPublicationAssignIdentifier { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string DdlCompany { get; set; }
    }
}
