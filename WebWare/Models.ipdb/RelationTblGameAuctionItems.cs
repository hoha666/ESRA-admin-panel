﻿using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblGameAuctionItems
    {
        public int Id { get; set; }
        public int? AuctionItemsId { get; set; }
        public int? TblGameId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
