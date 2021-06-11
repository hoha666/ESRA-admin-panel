using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblAuctionItemDisseminationListItemsCourse
    {
        public int Id { get; set; }
        public int? DisseminationListItemsCourseId { get; set; }
        public int? TblAuctionItemId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
