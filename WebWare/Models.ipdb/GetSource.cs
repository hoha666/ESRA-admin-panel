using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GetSource
    {
        public int Id { get; set; }
        public string TxtDate { get; set; }
        public string TxtGameName { get; set; }
        public string TxtPublisher { get; set; }
        public string CreatorGetSource { get; set; }
        public string IpGetSource { get; set; }
        public bool? RegistrationStatusGetSource { get; set; }
        public string RegistrationDateGetSource { get; set; }
        public string RegistrationTimeGetSource { get; set; }
        public string AuditStatusGetSource { get; set; }
        public string InstanceIdGetSource { get; set; }
        public int? InstanceSridGetSource { get; set; }
        public string DdlSourceType { get; set; }
        public string DdlSourceEtype { get; set; }
        public string AgeRatingRequestDoc { get; set; }
        public DateTime? TxtDateGregorian { get; set; }
    }
}
