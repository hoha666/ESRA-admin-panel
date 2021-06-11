using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblProducerNexclusiveNuserDisseminationPublishersAuctions
    {
        public int Id { get; set; }
        public int? DisseminationPublishersAuctionsId { get; set; }
        public int? TblProducerNexclusiveNuserId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
