using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Modules
    {
        public Modules()
        {
            Blocks = new HashSet<Blocks>();
        }

        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AdminFilePath { get; set; }
        public bool IsActive { get; set; }
        public bool IsVital { get; set; }

        public ICollection<Blocks> Blocks { get; set; }
    }
}
