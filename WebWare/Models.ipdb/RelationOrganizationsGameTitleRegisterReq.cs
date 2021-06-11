using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationOrganizationsGameTitleRegisterReq
    {
        public int Id { get; set; }
        public int? GameTitleRegisterReqId { get; set; }
        public int? OrganizationsId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
