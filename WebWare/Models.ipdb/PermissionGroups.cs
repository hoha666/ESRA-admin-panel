using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PermissionGroups
    {
        public int PermissionGroupId { get; set; }
        public int? ModuleId { get; set; }
        public string PermissionGroupTitle { get; set; }
    }
}
