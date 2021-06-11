using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Targets
    {
        public Targets()
        {
            Objectives = new HashSet<Objectives>();
        }

        public int Id { get; set; }
        public int Objectiveld { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string Time { get; set; }
        public int? BscId { get; set; }

        public Bscs Bsc { get; set; }
        public ICollection<Objectives> Objectives { get; set; }
    }
}
