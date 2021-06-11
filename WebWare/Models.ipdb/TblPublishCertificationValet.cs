using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPublishCertificationValet
    {
        public int IdPublishCertification { get; set; }
        public int IdFile { get; set; }
        public int IdUserEsra { get; set; }
        public int IdUserNezarat { get; set; }
        public int IdScreenshotType { get; set; }

        public TblFile1 IdFileNavigation { get; set; }
        public TblPublishCertification IdPublishCertificationNavigation { get; set; }
        public TblScreenshotType1 IdScreenshotTypeNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserEsraNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNezaratNavigation { get; set; }
    }
}
