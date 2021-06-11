using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GtblTest
    {
        public int Id { get; set; }
        public string CreatorGtblTest { get; set; }
        public string IpGtblTest { get; set; }
        public bool? RegistrationStatusGtblTest { get; set; }
        public string RegistrationDateGtblTest { get; set; }
        public string RegistrationTimeGtblTest { get; set; }
        public string AuditStatusGtblTest { get; set; }
        public string InstanceIdGtblTest { get; set; }
        public int? InstanceSridGtblTest { get; set; }
    }
}
