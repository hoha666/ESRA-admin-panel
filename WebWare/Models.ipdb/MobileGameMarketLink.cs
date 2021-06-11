using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGameMarketLink
    {
        public int Id { get; set; }
        public string DdlMarket { get; set; }
        public string TxtLink { get; set; }
        public string CreatorMobileGameMarketLink { get; set; }
        public string IpMobileGameMarketLink { get; set; }
        public bool? RegistrationStatusMobileGameMarketLink { get; set; }
        public string RegistrationDateMobileGameMarketLink { get; set; }
        public string RegistrationTimeMobileGameMarketLink { get; set; }
        public string AuditStatusMobileGameMarketLink { get; set; }
        public string InstanceIdMobileGameMarketLink { get; set; }
        public int? InstanceSridMobileGameMarketLink { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public MobileGameRating ParentRecord { get; set; }
    }
}
