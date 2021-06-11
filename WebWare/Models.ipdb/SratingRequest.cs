using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SratingRequest
    {
        public SratingRequest()
        {
            SourceRatingRequestSubform = new HashSet<SourceRatingRequestSubform>();
        }

        public int Id { get; set; }
        public string TxtGameName { get; set; }
        public string DdlLicenseType { get; set; }
        public string CreatorSratingRequest { get; set; }
        public string IpSratingRequest { get; set; }
        public bool? RegistrationStatusSratingRequest { get; set; }
        public string RegistrationDateSratingRequest { get; set; }
        public string RegistrationTimeSratingRequest { get; set; }
        public string AuditStatusSratingRequest { get; set; }
        public string InstanceIdSratingRequest { get; set; }
        public int? InstanceSridSratingRequest { get; set; }
        public string TxtSite { get; set; }

        public ICollection<SourceRatingRequestSubform> SourceRatingRequestSubform { get; set; }
    }
}
