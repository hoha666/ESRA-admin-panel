﻿using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationAuctionItems
    {
        public int Id { get; set; }
        public int? AuctionItemsId { get; set; }
        public int? Id1 { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
