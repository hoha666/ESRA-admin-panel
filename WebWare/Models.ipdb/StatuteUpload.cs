using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class StatuteUpload
    {
        public int Id { get; set; }
        public string Statute { get; set; }
        public string CreatorStatuteUpload { get; set; }
        public string IpStatuteUpload { get; set; }
        public bool? RegistrationStatusStatuteUpload { get; set; }
        public string RegistrationDateStatuteUpload { get; set; }
        public string RegistrationTimeStatuteUpload { get; set; }
        public string AuditStatusStatuteUpload { get; set; }
        public string InstanceIdStatuteUpload { get; set; }
        public int? InstanceSridStatuteUpload { get; set; }
    }
}
