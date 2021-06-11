using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Templates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatorId { get; set; }
        public string PersonAccess { get; set; }
        public string GroupAccess { get; set; }
        public string FilePath { get; set; }
    }
}
