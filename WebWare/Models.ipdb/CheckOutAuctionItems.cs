using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CheckOutAuctionItems
    {
        public int Id { get; set; }
        public string DdlResultOfReview { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorCheckOutAuctionItems { get; set; }
        public string IpCheckOutAuctionItems { get; set; }
        public bool? RegistrationStatusCheckOutAuctionItems { get; set; }
        public string RegistrationDateCheckOutAuctionItems { get; set; }
        public string RegistrationTimeCheckOutAuctionItems { get; set; }
        public string AuditStatusCheckOutAuctionItems { get; set; }
        public string InstanceIdCheckOutAuctionItems { get; set; }
        public int? InstanceSridCheckOutAuctionItems { get; set; }
    }
}
