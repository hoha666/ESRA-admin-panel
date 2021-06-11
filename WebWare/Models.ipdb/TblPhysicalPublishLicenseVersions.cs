using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPhysicalPublishLicenseVersions
    {
        public int VersionId { get; set; }
        public int PhysicalPublishLicenseId { get; set; }

        public TblPhysicalPublishLicense PhysicalPublishLicense { get; set; }
        public TblVersion1 Version { get; set; }
    }
}
