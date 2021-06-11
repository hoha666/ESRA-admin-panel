using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationPeopleContractFirstRequest
    {
        public int PeopleId { get; set; }
        public int ContractFirstRequestId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public ContractFirstRequest ContractFirstRequest { get; set; }
        public People People { get; set; }
    }
}
