using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PostRoles
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int RoleId { get; set; }
    }
}
