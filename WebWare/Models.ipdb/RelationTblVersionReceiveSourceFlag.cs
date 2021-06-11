using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionReceiveSourceFlag
    {
        public int Id { get; set; }
        public int? ReceiveSourceFlagId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
