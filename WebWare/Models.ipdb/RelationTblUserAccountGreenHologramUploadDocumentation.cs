using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblUserAccountGreenHologramUploadDocumentation
    {
        public int Id { get; set; }
        public int? GreenHologramUploadDocumentationId { get; set; }
        public int? TblUserAccountId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
