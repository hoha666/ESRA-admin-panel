using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RolePermissions
    {
        public int RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}
