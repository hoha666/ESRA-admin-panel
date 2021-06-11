using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class Menus
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alt { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public int? Header { get; set; }
    }
}
