using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGameGenresList
    {
        public int Id { get; set; }
        public string TxtGenre { get; set; }
        public string CreatorMobileGameGenresList { get; set; }
        public string IpMobileGameGenresList { get; set; }
        public bool? RegistrationStatusMobileGameGenresList { get; set; }
        public string RegistrationDateMobileGameGenresList { get; set; }
        public string RegistrationTimeMobileGameGenresList { get; set; }
        public string AuditStatusMobileGameGenresList { get; set; }
        public string InstanceIdMobileGameGenresList { get; set; }
        public int? InstanceSridMobileGameGenresList { get; set; }
    }
}
