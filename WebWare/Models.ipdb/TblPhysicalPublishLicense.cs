using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPhysicalPublishLicense
    {
        public TblPhysicalPublishLicense()
        {
            TblPhysicalPublishLicenseVersions = new HashSet<TblPhysicalPublishLicenseVersions>();
        }

        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public int? SignatureId { get; set; }
        public int? AuctionResultId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StateId { get; set; }
        public int? PublisherId { get; set; }
        public string Price { get; set; }
        public int? AccountId { get; set; }

        public ICollection<TblPhysicalPublishLicenseVersions> TblPhysicalPublishLicenseVersions { get; set; }
    }
}
