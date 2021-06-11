using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblItemVersions
    {
        public int IdVersion { get; set; }
        public int IdAuctionItem { get; set; }
        public bool? AddedLater { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? IdAddedUser { get; set; }

        public TblProducerNexclusiveNuser IdAddedUserNavigation { get; set; }
        public TblAuctionItem IdAuctionItemNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
