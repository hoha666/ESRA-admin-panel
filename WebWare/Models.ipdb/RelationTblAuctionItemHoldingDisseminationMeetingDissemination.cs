using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblAuctionItemHoldingDisseminationMeetingDissemination
    {
        public int Id { get; set; }
        public int? HoldingDisseminationMeetingDisseminationId { get; set; }
        public int? TblAuctionItemId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
