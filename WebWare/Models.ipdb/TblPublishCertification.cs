using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPublishCertification
    {
        public TblPublishCertification()
        {
            TblCertificationVersion = new HashSet<TblCertificationVersion>();
            TblPublishCertificationValet = new HashSet<TblPublishCertificationValet>();
        }

        public int Id { get; set; }
        public string CertificationNumber { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int IdApplicantUser { get; set; }
        public DateTime? ConfermDateTime { get; set; }
        public string SignatureName { get; set; }

        public TblProducerNexclusiveNuser IdApplicantUserNavigation { get; set; }
        public ICollection<TblCertificationVersion> TblCertificationVersion { get; set; }
        public ICollection<TblPublishCertificationValet> TblPublishCertificationValet { get; set; }
    }
}
