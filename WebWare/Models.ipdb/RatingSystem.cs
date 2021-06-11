using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RatingSystem
    {
        public int Id { get; set; }
        public string TxtRatingSystem { get; set; }
        public string TxtRating { get; set; }
        public string CreatorRatingSystem { get; set; }
        public string IpRatingSystem { get; set; }
        public bool? RegistrationStatusRatingSystem { get; set; }
        public string RegistrationDateRatingSystem { get; set; }
        public string RegistrationTimeRatingSystem { get; set; }
        public string AuditStatusRatingSystem { get; set; }
        public string InstanceIdRatingSystem { get; set; }
        public int? InstanceSridRatingSystem { get; set; }
    }
}
