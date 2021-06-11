using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PlatformsList
    {
        public int Id { get; set; }
        public string TxtPlatform { get; set; }
        public string CreatorPlatformsList { get; set; }
        public string IpPlatformsList { get; set; }
        public bool? RegistrationStatusPlatformsList { get; set; }
        public string RegistrationDatePlatformsList { get; set; }
        public string RegistrationTimePlatformsList { get; set; }
        public string AuditStatusPlatformsList { get; set; }
        public string InstanceIdPlatformsList { get; set; }
        public int? InstanceSridPlatformsList { get; set; }
    }
}
