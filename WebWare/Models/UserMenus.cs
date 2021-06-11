using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class UserMenus
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MenuId { get; set; }
    }
}
