using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationPeopleAgreementRequest
    {
        public int PeopleId { get; set; }
        public int AgreementRequestId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public AgreementRequest AgreementRequest { get; set; }
        public People People { get; set; }
    }
}
