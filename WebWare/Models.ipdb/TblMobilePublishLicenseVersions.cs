using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblMobilePublishLicenseVersions
    {
        public int Id { get; set; }
        public int MobilePublishLicenseId { get; set; }
        public int VersionId { get; set; }
        public DateTime AddDate { get; set; }
    }
}
