using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblCertificationVersion
    {
        public int IdVersion { get; set; }
        public int IdPublishCertification { get; set; }
        public int? IdUser { get; set; }
        public string CommentUser { get; set; }
        public bool CertificationStatus { get; set; }

        public TblPublishCertification IdPublishCertificationNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
