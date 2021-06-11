using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAuctionVote
    {
        public int IdAuction { get; set; }
        public int IdUser { get; set; }
        public int IdAuctionItem { get; set; }

        public TblAuctionItem IdAuctionItemNavigation { get; set; }
        public TblAuction IdAuctionNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
    }
}
