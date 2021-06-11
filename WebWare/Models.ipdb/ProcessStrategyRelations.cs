using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ProcessStrategyRelations
    {
        public int Id { get; set; }
        public int StrategyId { get; set; }
        public int ProcessId { get; set; }
        public string Weight { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
    }
}
