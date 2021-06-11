using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MenuItems
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public bool IsHorizontal { get; set; }
        public bool IsVertical { get; set; }
        public int AppearanceOrder { get; set; }
        public int ParentId { get; set; }
        public string ItemIcon { get; set; }
    }
}
