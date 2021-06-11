using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubWorkFlowExecutions
    {
        public int Id { get; set; }
        public string WorkFlowId { get; set; }
        public bool IsMainWorkFlowStop { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public string Description { get; set; }

        public NodeDetails IdNavigation { get; set; }
    }
}
