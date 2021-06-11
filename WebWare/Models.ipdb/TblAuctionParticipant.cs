using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAuctionParticipant
    {
        public int IdAuction { get; set; }
        public int IdUser { get; set; }

        public TblAuction IdAuctionNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
    }
}
