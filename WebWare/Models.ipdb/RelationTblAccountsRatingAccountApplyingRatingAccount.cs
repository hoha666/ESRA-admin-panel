using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblAccountsRatingAccountApplyingRatingAccount
    {
        public int Id { get; set; }
        public int? RatingAccountApplyingRatingAccountId { get; set; }
        public int? TblAccountsId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
