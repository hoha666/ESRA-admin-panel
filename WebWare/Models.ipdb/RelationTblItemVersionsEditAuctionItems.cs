using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblItemVersionsEditAuctionItems
    {
        public int Id { get; set; }
        public int? EditAuctionItemsId { get; set; }
        public int? TblItemVersionsId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
