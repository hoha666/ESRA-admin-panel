using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGameComment
    {
        public int Id { get; set; }
        public string TxtComment { get; set; }
        public string CreatorMobileGameComment { get; set; }
        public string IpMobileGameComment { get; set; }
        public bool? RegistrationStatusMobileGameComment { get; set; }
        public string RegistrationDateMobileGameComment { get; set; }
        public string RegistrationTimeMobileGameComment { get; set; }
        public string AuditStatusMobileGameComment { get; set; }
        public string InstanceIdMobileGameComment { get; set; }
        public int? InstanceSridMobileGameComment { get; set; }
    }
}
