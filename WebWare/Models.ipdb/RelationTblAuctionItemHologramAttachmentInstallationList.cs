﻿using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblAuctionItemHologramAttachmentInstallationList
    {
        public int Id { get; set; }
        public int? HologramAttachmentInstallationListId { get; set; }
        public int? TblAuctionItemId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
