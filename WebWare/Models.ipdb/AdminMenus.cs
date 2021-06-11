using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AdminMenus
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string PermissionName { get; set; }
        public int AppearanceOrder { get; set; }
        public int ParentId { get; set; }
        public string ItemIcon { get; set; }
    }
}
