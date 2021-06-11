using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationOrganizationsVersionInsertDecide
    {
        public int Id { get; set; }
        public int? VersionInsertDecideId { get; set; }
        public int? OrganizationsId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
