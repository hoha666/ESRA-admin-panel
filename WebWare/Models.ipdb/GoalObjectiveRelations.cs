using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GoalObjectiveRelations
    {
        public int Id { get; set; }
        public int GoalId { get; set; }
        public int ObjectiveId { get; set; }
        public string Weight { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
    }
}
