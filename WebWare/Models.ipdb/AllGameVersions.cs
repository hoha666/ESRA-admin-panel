using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AllGameVersions
    {
        public int Id { get; set; }
        public string CreatorAllGameVersions { get; set; }
        public string IpAllGameVersions { get; set; }
        public bool? RegistrationStatusAllGameVersions { get; set; }
        public string RegistrationDateAllGameVersions { get; set; }
        public string RegistrationTimeAllGameVersions { get; set; }
        public string AuditStatusAllGameVersions { get; set; }
        public string InstanceIdAllGameVersions { get; set; }
        public int? InstanceSridAllGameVersions { get; set; }
    }
}
