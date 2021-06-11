using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionEditItemSubEditItemUpload
    {
        public int Id { get; set; }
        public int? SubEditItemUploadId { get; set; }
        public int? TblVersionEditItemId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
