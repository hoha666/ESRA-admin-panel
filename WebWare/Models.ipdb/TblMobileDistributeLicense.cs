using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblMobileDistributeLicense
    {
        public int Id { get; set; }
        public int? MobilePublishLicenseId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string LicenseNumber { get; set; }
        public int StateId { get; set; }
        public int TypeId { get; set; }
    }
}
