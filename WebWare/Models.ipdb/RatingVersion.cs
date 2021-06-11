using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RatingVersion
    {
        public int Id { get; set; }
        public string CreatorRatingVersion { get; set; }
        public string IpRatingVersion { get; set; }
        public bool? RegistrationStatusRatingVersion { get; set; }
        public string RegistrationDateRatingVersion { get; set; }
        public string RegistrationTimeRatingVersion { get; set; }
        public string AuditStatusRatingVersion { get; set; }
        public string InstanceIdRatingVersion { get; set; }
        public int? InstanceSridRatingVersion { get; set; }
    }
}
