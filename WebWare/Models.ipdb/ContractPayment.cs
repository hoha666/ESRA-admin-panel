using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContractPayment
    {
        public int Id { get; set; }
        public string TxtPaymentNumber { get; set; }
        public string TxtPaymentPrice { get; set; }
        public string TxaComment { get; set; }
        public string CreatorContractPayment { get; set; }
        public string IpContractPayment { get; set; }
        public bool? RegistrationStatusContractPayment { get; set; }
        public string RegistrationDateContractPayment { get; set; }
        public string RegistrationTimeContractPayment { get; set; }
        public string AuditStatusContractPayment { get; set; }
        public string InstanceIdContractPayment { get; set; }
        public int? InstanceSridContractPayment { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
