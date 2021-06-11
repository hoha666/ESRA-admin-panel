using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblOrganizationBonyadSubmitSource
    {
        public int TblOrganizationBonyadId { get; set; }
        public int SubmitSourceId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public SubmitSource SubmitSource { get; set; }
        public TblOrganizationBonyad TblOrganizationBonyad { get; set; }
    }
}
