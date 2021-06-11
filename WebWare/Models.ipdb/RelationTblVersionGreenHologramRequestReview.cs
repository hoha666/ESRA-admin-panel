using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionGreenHologramRequestReview
    {
        public int Id { get; set; }
        public int? GreenHologramRequestReviewId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
