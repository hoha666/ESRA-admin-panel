using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContractConsultantForm
    {
        public int Id { get; set; }
        public string TxaConsult { get; set; }
        public string CreatorContractConsultantForm { get; set; }
        public string IpContractConsultantForm { get; set; }
        public bool? RegistrationStatusContractConsultantForm { get; set; }
        public string RegistrationDateContractConsultantForm { get; set; }
        public string RegistrationTimeContractConsultantForm { get; set; }
        public string AuditStatusContractConsultantForm { get; set; }
        public string InstanceIdContractConsultantForm { get; set; }
        public int? InstanceSridContractConsultantForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
