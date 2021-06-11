using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EditAuctionItems
    {
        public int Id { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorEditAuctionItems { get; set; }
        public string IpEditAuctionItems { get; set; }
        public bool? RegistrationStatusEditAuctionItems { get; set; }
        public string RegistrationDateEditAuctionItems { get; set; }
        public string RegistrationTimeEditAuctionItems { get; set; }
        public string AuditStatusEditAuctionItems { get; set; }
        public string InstanceIdEditAuctionItems { get; set; }
        public int? InstanceSridEditAuctionItems { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
