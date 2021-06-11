using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InsertAndEditRegisterAuctionItem
    {
        public int Id { get; set; }
        public long? NumDurationOfRepaymentLicense { get; set; }
        public string DdlMonopoly { get; set; }
        public string CreatorInsertAndEditRegisterAuctionItem { get; set; }
        public string IpInsertAndEditRegisterAuctionItem { get; set; }
        public bool? RegistrationStatusInsertAndEditRegisterAuctionItem { get; set; }
        public string RegistrationDateInsertAndEditRegisterAuctionItem { get; set; }
        public string RegistrationTimeInsertAndEditRegisterAuctionItem { get; set; }
        public string AuditStatusInsertAndEditRegisterAuctionItem { get; set; }
        public string InstanceIdInsertAndEditRegisterAuctionItem { get; set; }
        public int? InstanceSridInsertAndEditRegisterAuctionItem { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
