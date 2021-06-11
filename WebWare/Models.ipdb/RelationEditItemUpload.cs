using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationEditItemUpload
    {
        public int Id { get; set; }
        public int? EditItemUploadId { get; set; }
        public int? Id1 { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
