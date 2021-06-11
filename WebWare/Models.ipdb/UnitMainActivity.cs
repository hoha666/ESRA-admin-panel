using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UnitMainActivity
    {
        public int Id { get; set; }
        public string DdlUnit { get; set; }
        public string TxtMainActivity { get; set; }
        public string CreatorUnitMainActivity { get; set; }
        public string IpUnitMainActivity { get; set; }
        public bool? RegistrationStatusUnitMainActivity { get; set; }
        public string RegistrationDateUnitMainActivity { get; set; }
        public string RegistrationTimeUnitMainActivity { get; set; }
        public string AuditStatusUnitMainActivity { get; set; }
        public string InstanceIdUnitMainActivity { get; set; }
        public int? InstanceSridUnitMainActivity { get; set; }
    }
}
