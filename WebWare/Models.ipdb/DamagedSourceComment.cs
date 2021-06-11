using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DamagedSourceComment
    {
        public int Id { get; set; }
        public string TxaComment { get; set; }
        public string CreatorDamagedSourceComment { get; set; }
        public string IpDamagedSourceComment { get; set; }
        public bool? RegistrationStatusDamagedSourceComment { get; set; }
        public string RegistrationDateDamagedSourceComment { get; set; }
        public string RegistrationTimeDamagedSourceComment { get; set; }
        public string AuditStatusDamagedSourceComment { get; set; }
        public string InstanceIdDamagedSourceComment { get; set; }
        public int? InstanceSridDamagedSourceComment { get; set; }
    }
}
