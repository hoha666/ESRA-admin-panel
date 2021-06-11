using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAuctionWinner
    {
        public int IdAuctionItem { get; set; }
        public int IdUser { get; set; }
        public bool? Return { get; set; }
        public int Id { get; set; }

        public TblAuctionItem IdAuctionItemNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
    }
}
