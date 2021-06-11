using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionIssueLicensingForPublicOldGamesRequestIssuanceLicense
    {
        public int Id { get; set; }
        public int? IssueLicensingForPublicOldGamesRequestIssuanceLicenseId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
