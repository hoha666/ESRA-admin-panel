﻿using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionHologramAttachmentHologramNumber
    {
        public int Id { get; set; }
        public int? HologramAttachmentHologramNumberId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
