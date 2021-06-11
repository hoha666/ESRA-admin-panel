using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorkFlowDetails
    {
        public WorkFlowDetails()
        {
            NodeDetails = new HashSet<NodeDetails>();
            WfwInstances = new HashSet<WfwInstances>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FormId { get; set; }
        public string Json { get; set; }
        public string FieldName { get; set; }
        public int UnitId { get; set; }
        public int SubUnitId { get; set; }
        public bool IsActive { get; set; }
        public bool IsShow { get; set; }
        public string ProcessCode { get; set; }
        public int? WorkFlowProgressId { get; set; }
        public bool IsStart { get; set; }
        public string HelpFilePath { get; set; }
        public bool Anonymous { get; set; }
        public string JsonBpmn { get; set; }

        public WorkFlowProgresses WorkFlowProgress { get; set; }
        public ICollection<NodeDetails> NodeDetails { get; set; }
        public ICollection<WfwInstances> WfwInstances { get; set; }
    }
}
