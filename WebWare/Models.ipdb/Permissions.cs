using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Permissions
    {
        public int PermissionId { get; set; }
        public int PermissionGroupId { get; set; }
        public string PermissionName { get; set; }
        public string PermissionTitle { get; set; }
    }
}
