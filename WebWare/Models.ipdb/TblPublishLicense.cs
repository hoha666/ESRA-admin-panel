using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPublishLicense
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public int SigntureId { get; set; }
        public int AuctionResultId { get; set; }
        public DateTime StratDate { get; set; }
        public DateTime? EndDate { get; set; }

        public TblPublishLicense IdNavigation { get; set; }
        public TblPublishLicense InverseIdNavigation { get; set; }
    }
}
