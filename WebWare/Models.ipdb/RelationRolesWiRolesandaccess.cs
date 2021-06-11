using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationRolesWiRolesandaccess
    {
        public int Id { get; set; }
        public int? WiRolesandaccessId { get; set; }
        public int? RolesId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
