using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContractTozih
    {
        public int Id { get; set; }
        public string CreatorContractTozih { get; set; }
        public string IpContractTozih { get; set; }
        public bool? RegistrationStatusContractTozih { get; set; }
        public string RegistrationDateContractTozih { get; set; }
        public string RegistrationTimeContractTozih { get; set; }
        public string AuditStatusContractTozih { get; set; }
        public string InstanceIdContractTozih { get; set; }
        public int? InstanceSridContractTozih { get; set; }
    }
}
