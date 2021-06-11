using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblIranianPhysicalPublisherVersion
    {
        public int PhysicalUserId { get; set; }
        public int VersionId { get; set; }

        public TblProducerNexclusiveNuser PhysicalUser { get; set; }
        public TblVersion1 Version { get; set; }
    }
}
