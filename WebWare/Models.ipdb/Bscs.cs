using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Bscs
    {
        public Bscs()
        {
            Indices = new HashSet<Indices>();
            Targets = new HashSet<Targets>();
        }

        public int Id { get; set; }
        public int IndexId { get; set; }
        public string Measures { get; set; }
        public string Pivot { get; set; }
        public string Baseline { get; set; }
        public int TargetId { get; set; }
        public string GraphicalDisplay { get; set; }

        public ICollection<Indices> Indices { get; set; }
        public ICollection<Targets> Targets { get; set; }
    }
}
