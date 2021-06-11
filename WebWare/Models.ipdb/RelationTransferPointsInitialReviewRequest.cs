using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTransferPointsInitialReviewRequest
    {
        public int Id { get; set; }
        public int? TransferPointsInitialReviewRequestId { get; set; }
        public int? Id1 { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
