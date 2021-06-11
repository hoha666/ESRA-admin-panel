using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblAuctionItemenableEditAuctionItems
    {
        public int Id { get; set; }
        public int? EditAuctionItemsId { get; set; }
        public int? TblAuctionItemenableId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
