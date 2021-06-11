using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PbublishLicenseUpload
    {
        public int Id { get; set; }
        public string UploadFile { get; set; }
        public string CreatorPbublishLicenseUpload { get; set; }
        public string IpPbublishLicenseUpload { get; set; }
        public bool? RegistrationStatusPbublishLicenseUpload { get; set; }
        public string RegistrationDatePbublishLicenseUpload { get; set; }
        public string RegistrationTimePbublishLicenseUpload { get; set; }
        public string AuditStatusPbublishLicenseUpload { get; set; }
        public string InstanceIdPbublishLicenseUpload { get; set; }
        public int? InstanceSridPbublishLicenseUpload { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
