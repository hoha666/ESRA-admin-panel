using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblNezaratAuctionResult
    {
        public int Id { get; set; }
        public int AuctionItemId { get; set; }
        public int OrganizationId { get; set; }
        public int SuggestionValue { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
