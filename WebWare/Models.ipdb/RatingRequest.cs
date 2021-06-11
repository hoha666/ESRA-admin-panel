using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RatingRequest
    {
        public int Id { get; set; }
        public string TxtGameCode { get; set; }
        public string TxtIrPublisher { get; set; }
        public string Ddl2TestPlatform { get; set; }
        public string CreatorRatingRequest { get; set; }
        public string IpRatingRequest { get; set; }
        public bool? RegistrationStatusRatingRequest { get; set; }
        public string RegistrationDateRatingRequest { get; set; }
        public string RegistrationTimeRatingRequest { get; set; }
        public string AuditStatusRatingRequest { get; set; }
        public string InstanceIdRatingRequest { get; set; }
        public string DdlGamer { get; set; }
        public string DdlNarrator { get; set; }
        public string RatingDate { get; set; }
        public string DdlGameName { get; set; }
        public int? InstanceSridRatingRequest { get; set; }
        public string DdlResult { get; set; }
        public DateTime? RatingDateGregorian { get; set; }
    }
}
