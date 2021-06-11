using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SourceRatingRequestSubform
    {
        public int Id { get; set; }
        public string Ddlplatform { get; set; }
        public string TxtNumber { get; set; }
        public string DdlSourceType { get; set; }
        public string CreatorSourceRatingRequestSubform { get; set; }
        public string IpSourceRatingRequestSubform { get; set; }
        public bool? RegistrationStatusSourceRatingRequestSubform { get; set; }
        public string RegistrationDateSourceRatingRequestSubform { get; set; }
        public string RegistrationTimeSourceRatingRequestSubform { get; set; }
        public string AuditStatusSourceRatingRequestSubform { get; set; }
        public string InstanceIdSourceRatingRequestSubform { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string DdllPlatform { get; set; }
        public int? InstanceSridSourceRatingRequestSubform { get; set; }
        public string TxtSrsite { get; set; }

        public SratingRequest ParentRecord { get; set; }
    }
}
