using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwOperations
    {
        public WfwOperations()
        {
            WfwConditions = new HashSet<WfwConditions>();
        }

        public int Id { get; set; }
        public int DesisionId { get; set; }
        public string Gate { get; set; }
        public string Action { get; set; }

        public WfwDecisions Desision { get; set; }
        public ICollection<WfwConditions> WfwConditions { get; set; }
    }
}
