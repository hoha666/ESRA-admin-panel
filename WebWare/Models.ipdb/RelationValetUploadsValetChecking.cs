using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationValetUploadsValetChecking
    {
        public int ValetUploadsId { get; set; }
        public int ValetCheckingId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public ValetChecking ValetChecking { get; set; }
        public ValetUploads ValetUploads { get; set; }
    }
}
