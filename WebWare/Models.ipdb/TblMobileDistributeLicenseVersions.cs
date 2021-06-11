using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblMobileDistributeLicenseVersions
    {
        public int Id { get; set; }
        public int MobileDistributeLicenseId { get; set; }
        public int VersionId { get; set; }
        public DateTime AddDate { get; set; }
    }
}
