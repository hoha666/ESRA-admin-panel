using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class Modules
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
    }
}
