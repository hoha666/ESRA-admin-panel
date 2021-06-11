using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationSubFormGamerSeenContentGamerSeenContent
    {
        public int Id { get; set; }
        public int? GamerSeenContentId { get; set; }
        public int? SubFormGamerSeenContentId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
