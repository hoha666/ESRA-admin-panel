using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AddLevel1
    {
        public int Id { get; set; }
        public string TxtLevel1 { get; set; }
        public string CreatorAddLevel1 { get; set; }
        public string IpAddLevel1 { get; set; }
        public bool? RegistrationStatusAddLevel1 { get; set; }
        public string RegistrationDateAddLevel1 { get; set; }
        public string RegistrationTimeAddLevel1 { get; set; }
        public string AuditStatusAddLevel1 { get; set; }
        public string InstanceIdAddLevel1 { get; set; }
        public int? InstanceSridAddLevel1 { get; set; }
    }
}
