using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Roles
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleTitle { get; set; }
        public int PostId { get; set; }
        public bool IsDefaultForNewUser { get; set; }
    }
}
