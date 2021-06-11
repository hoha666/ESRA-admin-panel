using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationPeopleContractSealRequest
    {
        public int Id { get; set; }
        public int? ContractSealRequestId { get; set; }
        public int? PeopleId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
