using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblExclusiveVersions
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int VersionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NezaratAuctionResultId { get; set; }
    }
}
