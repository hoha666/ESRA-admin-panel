using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationContractPaymentContractSealRequest
    {
        public int Id { get; set; }
        public int? ContractSealRequestId { get; set; }
        public int? ContractPaymentId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
