using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionSimilarVersions
    {
        public int Id { get; set; }
        public int? SimilarVersionsId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
