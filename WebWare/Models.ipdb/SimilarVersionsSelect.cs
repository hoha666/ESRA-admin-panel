using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SimilarVersionsSelect
    {
        public int Id { get; set; }
        public string CreatorSimilarVersionsSelect { get; set; }
        public string IpSimilarVersionsSelect { get; set; }
        public bool? RegistrationStatusSimilarVersionsSelect { get; set; }
        public string RegistrationDateSimilarVersionsSelect { get; set; }
        public string RegistrationTimeSimilarVersionsSelect { get; set; }
        public string AuditStatusSimilarVersionsSelect { get; set; }
        public string InstanceIdSimilarVersionsSelect { get; set; }
        public int? InstanceSridSimilarVersionsSelect { get; set; }
    }
}
