using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AuctionItems
    {
        public int Id { get; set; }
        public int? NumDurationOfPublication { get; set; }
        public string CreatorAuctionItems { get; set; }
        public string IpAuctionItems { get; set; }
        public bool? RegistrationStatusAuctionItems { get; set; }
        public string RegistrationDateAuctionItems { get; set; }
        public string RegistrationTimeAuctionItems { get; set; }
        public string AuditStatusAuctionItems { get; set; }
        public string InstanceIdAuctionItems { get; set; }
        public int? InstanceSridAuctionItems { get; set; }
        public string DdllMonopoly { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
