using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AddLevel3
    {
        public int Id { get; set; }
        public string DdlLevel1 { get; set; }
        public string Ddl2Level2 { get; set; }
        public string TxtLevel3 { get; set; }
        public string CreatorAddLevel3 { get; set; }
        public string IpAddLevel3 { get; set; }
        public bool? RegistrationStatusAddLevel3 { get; set; }
        public string RegistrationDateAddLevel3 { get; set; }
        public string RegistrationTimeAddLevel3 { get; set; }
        public string AuditStatusAddLevel3 { get; set; }
        public string InstanceIdAddLevel3 { get; set; }
        public int? InstanceSridAddLevel3 { get; set; }
    }
}
