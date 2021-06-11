using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SimilarVersions
    {
        public int Id { get; set; }
        public string CreatorSimilarVersions { get; set; }
        public string IpSimilarVersions { get; set; }
        public bool? RegistrationStatusSimilarVersions { get; set; }
        public string RegistrationDateSimilarVersions { get; set; }
        public string RegistrationTimeSimilarVersions { get; set; }
        public string AuditStatusSimilarVersions { get; set; }
        public string InstanceIdSimilarVersions { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridSimilarVersions { get; set; }
    }
}
