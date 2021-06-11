using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionAnalizSubEditItemUpload
    {
        public int Id { get; set; }
        public int? SubEditItemUploadId { get; set; }
        public int? TblVersionAnalizId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
