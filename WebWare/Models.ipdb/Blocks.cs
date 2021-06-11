using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Blocks
    {
        public int BlockId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public bool IsAdminBlock { get; set; }
        public int? ModuleId { get; set; }

        public Modules Module { get; set; }
    }
}
