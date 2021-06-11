using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Strategies
    {
        public int Id { get; set; }
        public string EditorType { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public string StrengthId { get; set; }
        public string StrengthWeight { get; set; }
        public string WeaknessId { get; set; }
        public string WeaknessWeight { get; set; }
        public string OpportunityId { get; set; }
        public string OpportunityWeight { get; set; }
        public string ThreatId { get; set; }
        public string ThreatWeight { get; set; }
    }
}
