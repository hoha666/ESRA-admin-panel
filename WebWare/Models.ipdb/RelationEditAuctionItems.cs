using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationEditAuctionItems
    {
        public int Id { get; set; }
        public int? EditAuctionItemsId { get; set; }
        public int? Id1 { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
