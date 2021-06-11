using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationPeopleContractUpload
    {
        public int PeopleId { get; set; }
        public int ContractUploadId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public ContractUpload ContractUpload { get; set; }
        public People People { get; set; }
    }
}
