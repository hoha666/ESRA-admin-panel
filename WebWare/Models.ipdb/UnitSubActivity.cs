using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UnitSubActivity
    {
        public int Id { get; set; }
        public string DdlMainActivity { get; set; }
        public string TxtSubActivity { get; set; }
        public string CreatorUnitSubActivity { get; set; }
        public string IpUnitSubActivity { get; set; }
        public bool? RegistrationStatusUnitSubActivity { get; set; }
        public string RegistrationDateUnitSubActivity { get; set; }
        public string RegistrationTimeUnitSubActivity { get; set; }
        public string AuditStatusUnitSubActivity { get; set; }
        public string InstanceIdUnitSubActivity { get; set; }
        public int? InstanceSridUnitSubActivity { get; set; }
    }
}
