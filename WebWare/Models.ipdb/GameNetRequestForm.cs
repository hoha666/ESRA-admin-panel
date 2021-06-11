using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GameNetRequestForm
    {
        public int Id { get; set; }
        public string CreatorGameNetRequestForm { get; set; }
        public string IpGameNetRequestForm { get; set; }
        public bool? RegistrationStatusGameNetRequestForm { get; set; }
        public string RegistrationDateGameNetRequestForm { get; set; }
        public string RegistrationTimeGameNetRequestForm { get; set; }
        public string AuditStatusGameNetRequestForm { get; set; }
        public string InstanceIdGameNetRequestForm { get; set; }
        public int? InstanceSridGameNetRequestForm { get; set; }
    }
}
