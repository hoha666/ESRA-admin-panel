using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Sur030CheckExistenceVersion
    {
        public int Id { get; set; }
        public string DdlIsThereResultAtBase { get; set; }
        public string CreatorSur030CheckExistenceVersion { get; set; }
        public string IpSur030CheckExistenceVersion { get; set; }
        public bool? RegistrationStatusSur030CheckExistenceVersion { get; set; }
        public string RegistrationDateSur030CheckExistenceVersion { get; set; }
        public string RegistrationTimeSur030CheckExistenceVersion { get; set; }
        public string AuditStatusSur030CheckExistenceVersion { get; set; }
        public string InstanceIdSur030CheckExistenceVersion { get; set; }
        public int? InstanceSridSur030CheckExistenceVersion { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
