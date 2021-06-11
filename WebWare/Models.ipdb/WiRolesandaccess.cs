using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WiRolesandaccess
    {
        public int Id { get; set; }
        public string CreatorWiRolesandaccess { get; set; }
        public string IpWiRolesandaccess { get; set; }
        public bool? RegistrationStatusWiRolesandaccess { get; set; }
        public string RegistrationDateWiRolesandaccess { get; set; }
        public string RegistrationTimeWiRolesandaccess { get; set; }
        public string AuditStatusWiRolesandaccess { get; set; }
        public string InstanceIdWiRolesandaccess { get; set; }
        public int? InstanceSridWiRolesandaccess { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string TxtAccessGroup { get; set; }
    }
}
