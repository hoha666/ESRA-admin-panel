using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionOldGameReleaseLicenseSelectGame
    {
        public int Id { get; set; }
        public int? OldGameReleaseLicenseSelectGameId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
