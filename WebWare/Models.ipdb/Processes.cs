using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Processes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public int DocumentId { get; set; }
        public int ContactId { get; set; }
        public int PolicyId { get; set; }
        public int InstructionId { get; set; }
        public string IndexId { get; set; }
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public string Entity { get; set; }
        public string Unit { get; set; }
        public string Person { get; set; }
    }
}
